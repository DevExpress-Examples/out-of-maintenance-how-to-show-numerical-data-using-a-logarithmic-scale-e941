using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace LogarithmicScale {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnLogarithm10_Click(object sender, EventArgs e) {
            AxisY axis = ((XYDiagram)chartControl1.Diagram).AxisY;
            axis.Logarithmic = true;
            axis.LogarithmicBase = 10;
            axis.WholeRange.AlwaysShowZeroLevel = false;
        }

        private void btnLogarithm100_Click(object sender, EventArgs e) {
            AxisY axis = ((XYDiagram)chartControl1.Diagram).AxisY;
            axis.Logarithmic = true;
            axis.LogarithmicBase = 100;
            axis.WholeRange.AlwaysShowZeroLevel = false;
        }

        private void btnDisableLogarithm_Click(object sender, EventArgs e) {
            AxisY axis = ((XYDiagram)chartControl1.Diagram).AxisY;
            axis.Logarithmic = false;
            axis.WholeRange.AlwaysShowZeroLevel = true;
        }
    }
}