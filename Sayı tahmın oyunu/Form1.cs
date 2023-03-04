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
    public partial class Form1 : Form
    {
        Image[] resımler =
        {
            Properties.Resources.at,
            Properties.Resources.ejderha,
             Properties.Resources.fıl,
              Properties.Resources.kedı,
                Properties.Resources.koala,
                 Properties.Resources.penguen,
                 Properties.Resources.zurafa,
                 Properties.Resources.yunus,


        };
        int[] ındeksler = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resımlerıkarıstır();
            Random rnd = new Random();

            for (int i = 0; i < 16; i++)
            {
                int sayı = rnd.Next(16);
                int gecıcı = ındeksler[i];
                ındeksler[i] = ındeksler[sayı];
                ındeksler[sayı] = gecıcı;


            }
        }

        private void resımlerıkarıstır()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox kutu = (PictureBox)sender;
            int kutuNo = int.Parse(kutu.Name.Substring(10)) - 1;
            kutu.Image = resımler[ındeksler[kutuNo]];

        }
    }
}
