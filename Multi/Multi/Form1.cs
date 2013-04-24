using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Multi
{
    public partial class Form1 : Form
    {

        private int i, j;
        private int NombreErreurs = 0 , NombreBonnesReponses = 0;

        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newQuestion();
        }

        private void newQuestion()
        {
            Random generateur = new Random();
            i = generateur.Next(1, 10);
            j = generateur.Next(1, 10);
            this.label2.Text = "" + i.ToString() + " * " + j.ToString() + " ? ";  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == (i * j).ToString())
            {
                NombreBonnesReponses += 1;
                this.label6.Text = NombreBonnesReponses.ToString();
                this.textBox1.Text = "";
                this.label4.Text = "";
                this.newQuestion();
            }
            else
            {
                NombreErreurs += 1;
                this.label4.Text = "FAUX!";
                this.label8.Text = NombreErreurs.ToString();
                this.label4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_KeyUp(){

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
