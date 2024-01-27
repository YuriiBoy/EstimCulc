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
    public partial class AddCircles : Form
    {
        public int Number {  get; set; }
        public int Amount { get; set; }
        public double Radius { get; set; }
        public AddCircles()
        {
            InitializeComponent();
        }

        private void NextB_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            if(string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show(" Empty");
            }
            else
            {
                double r = Convert.ToDouble(data);
                if(r <= 0)
                    MessageBox.Show(" Radius is wrong");
                else
                {
                    Radius = r;
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void AddCircles_Load(object sender, EventArgs e)
        {
            Caption.Text = $"Коло # {Number} / {Amount}";
        }
    }
}
