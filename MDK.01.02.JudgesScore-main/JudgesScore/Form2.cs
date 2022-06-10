using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudgesScore
{
    public partial class Form2 : Form
    {
        int[] evaluations;

        public Form2(int[] eevaluations)
        {
            evaluations = eevaluations;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = evaluations[0].ToString();
            label8.Text = evaluations[1].ToString();
            label9.Text = evaluations[2].ToString();
            label10.Text = evaluations[3].ToString();
            label11.Text = evaluations[4].ToString();
            label12.Text = evaluations[5].ToString();
            label13.Text = evaluations[6].ToString();
            label14.Text = evaluations[7].ToString();
            label15.Text = evaluations[8].ToString();

            label2.Text = evaluations.Max().ToString();
            label4.Text = evaluations.Min().ToString();
            label6.Text = evaluations.Average().ToString();
        }
    }
}
