using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Move = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pct.Left + pct.Width + 20 <= this.Width) 
            {
                pct.Left += 20;
            }
            else
            {
                timer1.Stop();
                Move = false;
                btnStart.Text = "Старт";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Move) 
            {
                pct.Left = 0;
                timer1.Start();
                Move = true; 
                btnStart.Text = "Стоп";
            }
            else 
            {
                timer1.Stop();
                Move = false; 
                btnStart.Text = "Старт";
            }
        }
    }
}
