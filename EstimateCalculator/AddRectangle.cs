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
    public partial class AddRectangle : Form
    {
        public int Number { get; set; }
        public int Amount { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public AddRectangle()
        {
            InitializeComponent();
        }

        private void ContB_Click(object sender, EventArgs e)
        {
            string data1 = SideABox.Text;
            string data2 = SideBBox.Text;
            if (string.IsNullOrWhiteSpace(data1) || string.IsNullOrWhiteSpace(data2))
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                double a = Convert.ToDouble(data1);
                double b = Convert.ToDouble(data2);
                if (a <= 0 || b <= 0)
                {
                    MessageBox.Show("Sides can`t be less or equal to zero");
                }
                else
                {
                    SideA = a;
                    SideB = b;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }
            
        private void ClearBut_Click(object sender, EventArgs e)
        {
            SideABox.Clear();
            SideBBox.Clear();
        }
        private void AddRectangle_Load(object sender, EventArgs e)
        {
            Caption.Text = $"Прямокутник # {Number} / {Amount}";
        }
    }
}
