

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        karname f2 = new karname();
        double riyazi, fizik, gosaste, az, shabake,ave;

        private void button1_Click(object sender, EventArgs e)
        {

            riyazi = double.Parse(txt_riyazi_1.Text);
            fizik = double.Parse(txt_fizik_1.Text);
            gosaste = double.Parse(txt_gosaste_1.Text);
            az = double.Parse(txt_az_1.Text);
            shabake = double.Parse(txt_shabake_1.Text);
            ave = (riyazi + fizik + gosaste + az + shabake) / 5;
            lbl_moadel_1.Text = ave.ToString();

            if (ave > 10)
            {
                lbl_vaz_1.Text = "قبول";
                lbl_vaz_1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl_vaz_1.Text = "مردود";
                lbl_vaz_1.ForeColor = System.Drawing.Color.Red;
            }
            f2.lbl_nam_2.Text = this.txt_nam_1.Text;
            f2.lbl_shomareD_2.Text = this.txt_shomareD_1.Text;
            f2.lbl_tarikh_2.Text = this.txt_tarikh_1.Text;
            f2.lbl_moadel_2.Text = this.lbl_moadel_1.Text;
            f2.lbl_vaz_2.Text = this.lbl_vaz_1.Text;
            f2.lbl_riyazi_2.Text = this.txt_riyazi_1.Text;
            f2.lbl_fizik_2.Text = this.txt_fizik_1.Text;
            f2.lbl_gosaste_2.Text = this.txt_gosaste_1.Text;
            f2.lbl_az_2.Text = this.txt_az_1.Text;
            f2.lbl_shabake_2.Text = this.txt_shabake_1.Text;
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            riyazi = double.Parse(txt_riyazi_1.Text);
            fizik = double.Parse(txt_fizik_1.Text);
          gosaste = double.Parse(txt_gosaste_1.Text);
            az = double.Parse(txt_az_1.Text);
           shabake = double.Parse(txt_shabake_1.Text);
            ave = (riyazi + fizik + gosaste + az + shabake) / 5;
            lbl_moadel_1.Text = ave.ToString();

            if(ave>10)
            {
                lbl_vaz_1.Text = "قبول";
                lbl_vaz_1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl_vaz_1.Text = "مردود";
                lbl_vaz_1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
