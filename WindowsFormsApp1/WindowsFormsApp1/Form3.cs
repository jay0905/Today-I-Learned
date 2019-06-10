using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random ran = new Random();
        int[] random = new int[5];
        int[] temp = new int[5];
        int pos;

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                temp[i] = i;
            }

            for(int i = 0; i < 5; i++)
            {
                pos = ran.Next(5 - i);
                random[i] = temp[pos];
                temp[pos] = temp[4 - i];
            }
        }

        int picnum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            groupBox1.Enabled = true;

            if(picnum < 5)
            {
                radio_false();
                pictureBox1.ImageLocation = Application.StartupPath + @"\" + random[picnum] + ".JPG";
                picnum++;
            }
            else if(picnum == 5){
                MessageBox.Show("수고하셨습니다");
                this.Close();
            }

        }

        private void radio_false()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        
    }
}
