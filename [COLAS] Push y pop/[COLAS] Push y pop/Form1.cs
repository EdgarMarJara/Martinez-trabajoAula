using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _COLAS__Push_y_pop
{
    public partial class Form1 : Form
    {
        int td = 0;
        Random objeto = new Random();
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (td == 5)
            {
                MessageBox.Show ("La Cola esta llena");
            }
            else
            {
                td++;
                t6.Text = Convert.ToString(td);
                if(td == 1)
                {
                    t1.Text = Convert.ToString(objeto.Next(1, 99));
                    t1.Visible = true;
                }
                if (td == 2)
                {
                    t2.Text = Convert.ToString(objeto.Next(1, 99));
                    t2.Visible = true;
                }
                if (td == 3)
                {
                    t3.Text = Convert.ToString(objeto.Next(1, 99));
                    t3.Visible = true;
                }
                if (td == 4)
                {
                    t4.Text = Convert.ToString(objeto.Next(1, 99));
                    t4.Visible = true;
                }
                if (td == 5)
                {
                    t5.Text = Convert.ToString(objeto.Next(1, 99));
                    t5.Visible = true;
                }
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (td == 0) MessageBox.Show("La cola esta vacia weon");

            else 
            {
                t1.Text = t2.Text;
                t2.Text = t3.Text;
                t3.Text = t4.Text;
                t4.Text = t5.Text;
                if (td == 1) t1.Visible = false;
                if (td == 2) t2.Visible = false;
                if (td == 3) t3.Visible = false;
                if (td == 4) t4.Visible = false;
                if (td == 5) t5.Visible = false;
                td--;
                t6.Text = Convert.ToString(td);
            }
        }
    }
}
