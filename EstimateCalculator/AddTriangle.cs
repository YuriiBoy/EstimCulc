using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimateCalculator
{
    public partial class AddTriangle : Form
    {
        public int Number {  get; set; }
        public int Amount {  get; set; }
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public AddTriangle()
        {
            InitializeComponent();
        }

        private void ContB_Click(object sender, EventArgs e)
        {
            string data = SideABox.Text;
            string data1 = SideBBox.Text;
            string data2 = SideCBox.Text;
            if (string.IsNullOrWhiteSpace(data) || string.IsNullOrWhiteSpace(data1) ||
                string.IsNullOrWhiteSpace(data2))
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                double a = Convert.ToDouble(data);
                double b = Convert.ToDouble(data1);
                double c = Convert.ToDouble(data2);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("Sides can`t be less or equal to zero");
                }
                else
                {
                    SideA = a;
                    SideB = b;
                    SideC = c;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            SideABox.Clear();
            SideBBox.Clear();
            SideCBox.Clear();
        }

        private void AddTriangle_Load(object sender, EventArgs e)
        {
            Caption.Text = $"Трикутник  # {Number} / {Amount}";
        }
    }
}
