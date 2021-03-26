using System;
using System.Windows.Forms;

namespace Hyperboloid
{
    public partial class HyperboloidSurfaceVolumeCalculatingForm : Form
    {
        public HyperboloidSurfaceVolumeCalculatingForm()
        {
            InitializeComponent();
        }

        public HyperboloidSurfaceVolumeCalculatingForm(double a, double c, double h) : this()
        {
            AValue.Value = (decimal)a;
            CValue.Value = (decimal)c;
            HValue.Value = (decimal)h;

            Calculate();
        }

        private void Calculate()
        {
            var hyperboloid = new Hyperboloid((double)AValue.Value, (double)AValue.Value, (double)CValue.Value);
            var surfaceVolume = hyperboloid.CalculateSurfaceVolume((double)HValue.Value);
            SurfaceVolumeValue.Text = surfaceVolume.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
