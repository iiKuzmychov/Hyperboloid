using System;
using System.Windows.Forms;

namespace Hyperboloid
{
    public partial class BodyInertiaMomentsCalculationForm : Form
    {
        public BodyInertiaMomentsCalculationForm()
        {
            InitializeComponent();
        }

        public BodyInertiaMomentsCalculationForm(double a, double c, double h) : this()
        {
            AValue.Value = (decimal)a;
            CValue.Value = (decimal)c;
            HValue.Value = (decimal)h;

            Calculate();
        }

        private void Calculate()
        {
            var hyperboloid = new HyperboloidOfRevolution((double)AValue.Value, (double)CValue.Value);
            var height      = (double)HValue.Value;
            var mass        = 1;

            IxyValue.Text   = hyperboloid.CalculateBodyInertiaMomentOxy(height, mass).ToString();
            IxzValue.Text   = hyperboloid.CalculateBodyInertiaMomentOxz(height, mass).ToString();
            IyzValue.Text   = hyperboloid.CalculateBodyInertiaMomentOyz(height, mass).ToString();
            IxValue.Text    = hyperboloid.CalculateBodyInertiaMomentOx(height, mass).ToString();
            IyValue.Text    = hyperboloid.CalculateBodyInertiaMomentOy(height, mass).ToString();
            IzValue.Text    = hyperboloid.CalculateBodyInertiaMomentOz(height, mass).ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
