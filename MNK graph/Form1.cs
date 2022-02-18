using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MNK_graph
{
    public partial class Form1 : Form
    {
        private string x;
        private string y;
        private bool checker;
        private bool checker1 = true;

        public Form1()
        {
            InitializeComponent();

            graph.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            graph.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void graph_1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xList_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(xList.Text))
            {
                errorProvider1.SetError(xList, "Укажите координаты");
                this.checker1 = true;
                goto ERROR1;
            }

            this.x = xList.Text.Trim();
            this.y = yList.Text.Trim();
            string[] delim = { " ", "  " };

            var x1Arr = this.x.Split(' ').Select(Double.Parse).ToArray();
            var y1Arr = this.y.Split(' ').Select(Double.Parse).ToArray();

            if (x1Arr.Length != y1Arr.Length)
            {
                this.checker = true;
            }

            double[] xArr = new double[Math.Min(x1Arr.Length, y1Arr.Length)];
            double[] yArr = new double[Math.Min(x1Arr.Length, y1Arr.Length)];
            CoordValid();

            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();


            if (x1Arr.Length > y1Arr.Length)
            {
                Array.Copy(x1Arr, 0, xArr, 0, Math.Min(x1Arr.Length, y1Arr.Length));
                yArr = y1Arr;
                this.checker = true;
            }

            else if (x1Arr.Length < y1Arr.Length)
            {
                Array.Copy(y1Arr, 0, yArr, 0, Math.Min(x1Arr.Length, y1Arr.Length));
                xArr = x1Arr;
                this.checker = true;
            }
            else
            {
                xArr = x1Arr;
                yArr = y1Arr;
                this.checker = false;
            }

            for (int i = 0; i < Math.Min(x1Arr.Length, y1Arr.Length); i++)
            {
                graph.Series[0].Points.AddXY(xArr[i], yArr[i]);
            }
            double a, b;

            Approx(xArr, yArr, out a, out b);

            TestTextOut.Text = $"a = {a:F3}, b = {b:F3}";
            graph.Series[1].Points.AddXY((xArr[0]), (xArr[0] * a + b));
            graph.Series[1].Points.AddXY((xArr[xArr.Length - 1]), (xArr[xArr.Length - 1] * a + b));
            CoordValid();
            ERROR1:;



        }
        private void Approx(double[] x, double[] y, out double a, out double b)
        {
            int n = x.Length;
            double[] xy = new double[n];
            double[] x2 = new double[n];
            double xSum,ySum, xySum, x2Sum;
            xSum = ySum = xySum = x2Sum = 0;
            
            for (int i = 0; i < n; i++) xSum += x[i];
            for (int i = 0; i < n; i++) ySum += y[i];
            for (int i = 0; i < n; i++) xySum += y[i]*x[i];
            for (int i = 0; i < n; i++) x2Sum += x[i]*x[i];
           

            a = (xSum * ySum - n * xySum) / ((xSum * xSum) - (n * x2Sum));
            b = (xSum * xySum - x2Sum * ySum) / (xSum * xSum - n * x2Sum);
        }

        private void TestTextOut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();
            xList.Text = "";
            yList.Text = "";
        }

        private void import_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;                    
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            char[] delim = { ' ', '\t', '\n', '\r' };
            string [] arr = fileContent.Split(delim);
            var n = arr.Length / 2;
            string[] xarr = new string[n];
            string[] yarr = new string[n];
            Array.Copy(arr, xarr, n);
            Array.Copy(arr, n+1, yarr, 0, n);

            xList.Text = String.Join(" ", xarr);
            yList.Text = String.Join(" ", yarr);
        }
        private void CoordValid()
        {
            if (String.IsNullOrEmpty(xList.Text))
            {
                errorProvider1.SetError(xList, "Укажите координаты");
                this.checker1 = true;
            }
            else if (this.checker)
            {
                errorProvider1.SetError(xList, "Кол-во координат не совпадает");
                this.checker1 = true;
            }
            else if (String.IsNullOrEmpty(yList.Text))
            {
                errorProvider1.SetError(yList, "Укажите координаты");
            }
            else
            {
                errorProvider1.Clear();
                this.checker1 = false;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
