using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hyperboloid
{
    public partial class MainForm : Form
    {
        private GraphicsEngine3D graphicsEngine = new GraphicsEngine3D() { BackgroundColor = Color.Gray };
        private Graphics graphics;
        private HyperboloidOfRevolution hyperboloid;
        private bool autoUpdate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateHyperboloid();

            autoUpdate = AutoUpdateBox.Checked;
            AutoUpdateBox_CheckedChanged(this, null);

            graphics = GraphicsPanel.CreateGraphics();
            SmoothBox_CheckedChanged(this, null);

            AddToChartButton_Click(this, null);
        }

        private void UpdateHyperboloid()
        {
            var hyperboloidMaxZ = (double)HValue.Value / 2;
            var hyperboloidMinZ = -hyperboloidMaxZ;
            hyperboloid         = new HyperboloidOfRevolution((double)AValue.Value, (double)CValue.Value, hyperboloidMinZ, hyperboloidMaxZ);
        }

        #region События, связанные с отрисовкой

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            var centerCircle    = (Circle)hyperboloid.GetZAxisSection(0);
            var upCircle        = (Circle)hyperboloid.GetZAxisSection(hyperboloid.MaxZ);
            var downCircle      = (Circle)hyperboloid.GetZAxisSection(hyperboloid.MinZ);

            graphicsEngine.Figures3D.Clear();
            graphicsEngine.Figures2D.Clear();
            graphicsEngine.Figures3D.Add((hyperboloid, Color.White));
            graphicsEngine.Figures2D.Add((centerCircle, 0, Color.Black));
            graphicsEngine.Figures2D.Add((upCircle, hyperboloid.MaxZ, Color.Red));
            graphicsEngine.Figures2D.Add((downCircle, hyperboloid.MinZ, Color.Red));

            graphicsEngine.ZeroPositionOffset   = new Point3D((double)GraphicsPanel.Width / 2, (double)GraphicsPanel.Height / 2, 0);
            graphicsEngine.Figures3DStep        = (double)StepBar.Value / 10;
            graphicsEngine.Figures2DStep        = (double)StepBar.Value / 50;
            graphicsEngine.ScaleFactor          = (double)ScaleFactorBar.Value / 10;
            graphicsEngine.Rotation             = Vector3D.FromDegrees(XRotationBar.Value, YRotationBar.Value, ZRotationBar.Value);

            GraphicsPanel.SuspendLayout();            
            graphicsEngine.Draw(graphics);
            GraphicsPanel.ResumeLayout();
        }

        private void GraphicsPanel_Resize(object sender, EventArgs e)
        {
            graphics?.Dispose();
            graphics = GraphicsPanel.CreateGraphics();

            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void SmoothBox_CheckedChanged(object sender, EventArgs e)
        {
            if (graphics is null)
                return;

            if (SmoothBox.Checked)
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
            else
                graphics.SmoothingMode = SmoothingMode.None;

            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            GraphicsPanel.Refresh();
        }

        private void AutoUpdateBox_CheckedChanged(object sender, EventArgs e)
        {
            autoUpdate = AutoUpdateBox.Checked;

            if (autoUpdate)
            {
                DrawButton.Enabled = false;
                GraphicsPanel.Refresh();
            }
            else
            {
                DrawButton.Enabled = true;
            }
        }

        private void StepBar_ValueChanged(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void ScaleFactorBar_ValueChanged(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void ResetScaleFactorButton_Click(object sender, EventArgs e)
        {
            ScaleFactorBar.Value = 10;
        }

        private void ResetStepButton_Click(object sender, EventArgs e)
        {
            StepBar.Value = 10;
        }

        private void XRotationBar_Scroll(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void YRotationBar_Scroll(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void ZRotationBar_Scroll(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        #endregion

        #region События, связанные с изменением параметров гиперболоиды

        private void AValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateHyperboloid();

            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void CValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateHyperboloid();

            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void HValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateHyperboloid();

            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        #endregion 

        #region Меню "Рассчёты"

        private void OpenVolumeCalculationgFormButton_Click(object sender, EventArgs e)
        {
            var calculatingForm = new HyperboloidVolumeCalculatingForm((double)AValue.Value, (double)CValue.Value, (double)HValue.Value);
            calculatingForm.Show(this);
        }

        private void OpenBodyInertiaMomentsCalculationFormButton_Click(object sender, EventArgs e)
        {
            var calculatingForm = new BodyInertiaMomentsCalculationForm((double)AValue.Value, (double)CValue.Value, (double)HValue.Value);
            calculatingForm.Show(this);
        }

        #endregion

        #region События, связанные с графиком

        private void AddToChartButton_Click(object sender, EventArgs e)
        {
            var height      = (double)HValue.Value;
            var mass        = 1;
            var Ixy         = hyperboloid.CalculateBodyInertiaMomentOxy(height, mass);
            var Ixz         = hyperboloid.CalculateBodyInertiaMomentOxz(height, mass);
            var Iyz         = hyperboloid.CalculateBodyInertiaMomentOyz(height, mass);
            var Ix          = hyperboloid.CalculateBodyInertiaMomentOx(height, mass);
            var Iy          = hyperboloid.CalculateBodyInertiaMomentOy(height, mass);
            var Iz          = hyperboloid.CalculateBodyInertiaMomentOz(height, mass);
;
            ParametrsChart.Series["Ixy"].Points.AddY(Ixy);
            ParametrsChart.Series["Ixz"].Points.AddY(Ixz);
            ParametrsChart.Series["Iyz"].Points.AddY(Iyz);
            ParametrsChart.Series["Ix"].Points.AddY(Ix);
            ParametrsChart.Series["Iy"].Points.AddY(Iy);
            ParametrsChart.Series["Iz"].Points.AddY(Iz);
        }

        private void ClearChartButton_Click(object sender, EventArgs e)
        {
            ParametrsChart.Series["Ixy"].Points.Clear();
            ParametrsChart.Series["Ixz"].Points.Clear();
            ParametrsChart.Series["Iyz"].Points.Clear();
            ParametrsChart.Series["Ix"].Points.Clear();
            ParametrsChart.Series["Iy"].Points.Clear();
            ParametrsChart.Series["Iz"].Points.Clear();
        }

        #endregion
    }
}
