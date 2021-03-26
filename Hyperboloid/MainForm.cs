using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hyperboloid
{
    public partial class MainForm : Form
    {
        private Graphics graphics;
        private GraphicsEngine3D graphicsEngine = new GraphicsEngine3D() { BackgroundColor = Color.Gray };
        private bool autoUpdate;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            autoUpdate = AutoUpdateBox.Checked;
            AutoUpdateBox_CheckedChanged(this, null);

            graphics = GraphicsPanel.CreateGraphics();
            SmoothBox_CheckedChanged(this, null);
        }

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            var hyperboloidMaxZ = (double)HValue.Value / 2;
            var hyperboloidMinZ = -(double)HValue.Value / 2;
            var hyperboloid     = new Hyperboloid((double)AValue.Value, (double)AValue.Value, (double)CValue.Value, hyperboloidMinZ, hyperboloidMaxZ);
            var centerEllipse   = (Ellipse)hyperboloid.GetZAxisSection(0);
            var upEllipse       = (Ellipse)hyperboloid.GetZAxisSection(hyperboloidMaxZ);
            var downEllipse     = (Ellipse)hyperboloid.GetZAxisSection(hyperboloidMinZ);

            graphicsEngine.Figures3D.Clear();
            graphicsEngine.Figures2D.Clear();
            graphicsEngine.Figures3D.Add((hyperboloid, Color.White));
            graphicsEngine.Figures2D.Add((centerEllipse, 0, Color.Black));
            graphicsEngine.Figures2D.Add((upEllipse, hyperboloidMaxZ, Color.Red));
            graphicsEngine.Figures2D.Add((downEllipse, hyperboloidMinZ, Color.Red));

            graphicsEngine.ZeroPositionOffset   = new Point3D((double)GraphicsPanel.Width / 2, (double)GraphicsPanel.Height / 2, 0);
            graphicsEngine.Figures3DStep        = (double)StepBar.Value / 10;
            graphicsEngine.ScaleFactor          = (double)ScaleFactorBar.Value / 10;
            graphicsEngine.Rotation             = Vector3D.FromDegrees(XRotationBar.Value, YRotationBar.Value, ZRotationBar.Value);

            GraphicsPanel.SuspendLayout();
            graphicsEngine.Draw(graphics);
            GraphicsPanel.ResumeLayout();
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

        private void GraphicsPanel_Resize(object sender, EventArgs e)
        {
            graphics?.Dispose();
            graphics = GraphicsPanel.CreateGraphics();
        }

        private void AValue_ValueChanged(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void CValue_ValueChanged(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
        }

        private void HValue_ValueChanged(object sender, EventArgs e)
        {
            if (autoUpdate)
                GraphicsPanel.Refresh();
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

        private void OpenSurfaceVolumeCalculationgForm_Click(object sender, EventArgs e)
        {
            var calculatingForm = new HyperboloidSurfaceVolumeCalculatingForm((double)AValue.Value, (double)CValue.Value, (double)HValue.Value);
            calculatingForm.Show();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
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
    }
}
