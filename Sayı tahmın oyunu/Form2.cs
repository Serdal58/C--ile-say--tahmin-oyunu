using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int zaman = 6;
        int puan = 0;
        Random s = new Random();
       

        private void BTNBASLA_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sayı3, sayı4, sayı5, sayı6, sayı7, sayı8, sayı9;
            sayı1 = s.Next(0, 40);
            sayı2 = s.Next(0, 40);
            sayı3 = s.Next(0, 40);
            sayı4 = s.Next(0, 40);
            sayı5 = s.Next(0, 40);
            sayı6 = s.Next(0, 40);
            sayı7 = s.Next(0, 40);
            sayı8=s.Next(0, 40);
            sayı9 = s.Next(0, 40);

            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();
            label6.Text = sayı6.ToString();
            label7.Text = sayı7.ToString();
            label8.Text = sayı8.ToString();
            label9.Text = sayı9.ToString();

            timer1.Start();
            BTNBASLA.Enabled = false;

            


        }

        private void btnkontol_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==label1.Text&&textBox2.Text==label2.Text&&textBox3.Text==label3.Text&&textBox4.Text==label4.Text&&textBox5.Text==label5.Text&&textBox6.Text==label6.Text&&textBox7.Text==label7.Text&&textBox8.Text==label8.Text&&textBox9.Text==label9.Text)
            {
                MessageBox.Show("Tebrikler kazandınız");
                puan += 10;
                label12.Text = puan.ToString();
                

                
                
            }
            else
            {
                MessageBox.Show("Kaybettiniz");
            }
           
        
        
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            zaman--;
            label10.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Stop();
                groupBox1.Visible = false;
                zaman = 6;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            timer1.Start();
            button1.Enabled = false;



        }

        private void btnyenıden_Click(object sender, EventArgs e)
        {
            Application.Restart();


        }
    }
}
