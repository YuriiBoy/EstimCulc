using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstimateCalculator.Models;

namespace EstimateCalculator
{
    public partial class Form1 : Form
    {
        public List<Shape> Shapes {  get; set; }
       
        public Form1()
        {
            InitializeComponent();
            Shapes = new List<Shape>();
            
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // circle
            int count1 = (int)CircleCount.Value;
            if (count1 > 0)
            {
                // 
                for (int i = 0; i < count1; i++)
                {
                    //
                    var addCirclF = new AddCircles()
                    {
                        Number = i + 1,
                        Amount = count1
                    };
                    //
                    if (addCirclF.ShowDialog() == DialogResult.OK)
                    {
                        double r = addCirclF.Radius;
                        Shapes.Add(new Circle(r));
                    }
                }
            }
            // rectangle
            int count2 = (int)RectanglesCount.Value;
            if(count2 > 0)
            {
                for(int i = 0; i < count2;  i++)
                {
                    var addRectangleF = new AddRectangle() {
                        Number = i + 1,
                        Amount = count2
                    };
                    if(addRectangleF.ShowDialog() == DialogResult.OK)
                    {
                        double a = addRectangleF.SideA;
                        double b = addRectangleF.SideB;
                        //Shapes.Add(new Rectangle(a, b));
                       
                    }
                }
            }

            int count3 = (int)TrianglesCount.Value;
            if (count3 > 0)
            {
                // 
                for (int i = 0; i < count3; i++)
                {
                    //
                    var addTrianglelF = new AddTriangle()
                    {
                        Number = i + 1,
                        Amount = count3
                    };
                    //
                    if (addTrianglelF.ShowDialog() == DialogResult.OK)
                    {
                        double a = addTrianglelF.SideA;
                        double b = addTrianglelF.SideB;
                        double c = addTrianglelF.SideC;
                        Shapes.Add(new Triangle(a, b, c));
                    }
                }
            }

            // general test
            foreach (var item in Shapes)
            {
                Results.Text += item.ToString() + "\r\n"; // \r\n - переход на следующий ряд
            }
            Shapes.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            Results.Clear();
        }
    }
}
