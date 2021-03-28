using System;
using System.Windows.Forms;

namespace Hyperboloid
{
    public partial class HyperboloidVolumeCalculatingForm : Form
    {
        public HyperboloidVolumeCalculatingForm()
        {
            InitializeComponent();
        }

        public HyperboloidVolumeCalculatingForm(double a, double c, double h) : this()
        {
            AValue.Value = (decimal)a;
            CValue.Value = (decimal)c;
            HValue.Value = (decimal)h;

            Calculate();
        }

        private void Calculate()
        {
            var hyperboloid = new HyperboloidOfRevolution((double)AValue.Value, (double)CValue.Value);
            var surfaceVolume = hyperboloid.CalculateVolume((double)HValue.Value);
            SurfaceVolumeValue.Text = surfaceVolume.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
