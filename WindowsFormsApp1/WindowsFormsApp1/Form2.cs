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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void FileSave(string name, string sex, string grade)
        {
            FileStream SAVE = new FileStream("id.txt", FileMode.OpenOrCreate);
            StreamWriter w = new StreamWriter(SAVE, System.Text.Encoding.Default);
            w.BaseStream.Seek(0, SeekOrigin.End);
            w.WriteLine(name + "\t" + sex + "\t" + grade);
            w.Flush();
            w.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sex;
            string grade;
           
            if(radioButton1.Checked == true || radioButton2.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    sex = "여자";
                }
                else sex = "남자";
            }
            else
            {
                MessageBox.Show("성별을 선택해 주세요");
                return;
            }

            switch (comboBox1.Text)
            {
                case "1학년":
                    grade = "1학년";
                    break;
                case "2학년":
                    grade = "2학년";
                    break;
                default:
                    MessageBox.Show("학년을 선택해주세요");
                    return;
            }
            FileSave(name, sex, grade);
            this.Close();
        }
    }
}
