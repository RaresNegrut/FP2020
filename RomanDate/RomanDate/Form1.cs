using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanDate
{
    public partial class Form1 : Form
    {
        int dd;
        int mm;
        int yy;
        string conversie(int i,string A,string B,string C)
        {
            string tor = "";
            switch(i)
            {
                case 1: tor += A;break;
                case 2: tor += A + A;break;
                case 3: tor += A + A + A;break;
                case 4: tor += A + B;break;
                case 5: tor += B;break;
                case 6: tor += B + A;break;
                case 7: tor += B + A + A;break;
                case 8: tor += B + A + A + A;break;
                case 9: tor += A + C;break;
            }
            return tor;
        }
        string convert_numeral(int a)
        {
            int[] v = new int[5];
            int i = 0;
            while (a != 0)
            {
                v[i] = a % 10;
                a /= 10;
                i++;
            }

            string tor = "";
            tor += conversie(v[4], "[X]", "NULL", "NULL");
            tor += conversie(v[3], "M", "[V]", "[X]");
            tor += conversie(v[2], "C", "D", "M");
            tor += conversie(v[1], "X", "L", "C");
            tor += conversie(v[0], "I", "V", "X");

            return tor;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                mm = int.Parse(textBox1.Text);
            }
            catch { }

            try
            {
                dd = int.Parse(textBox2.Text);
            }
            catch { }

            try
            {
                yy = int.Parse(textBox3.Text);
            }
            catch { }

            if (dd == -1 && mm == -1 && yy == -1)
            {
                listBox1.Items.Add("Answear");
                listBox1.Items.Add("Enter at least one value for month, day or year.");
            }
            else
            {
                bool dd_ok = false;
                bool mm_ok = false;
                bool yy_ok = false;

                if (dd >= 1 && dd <= 31)
                    dd_ok = true;
                if (mm >= 1 && mm <= 12)
                    mm_ok = true;
                if (yy >= 1 && yy <= 30999)
                    yy_ok = true;

                if (dd_ok && mm_ok && yy_ok)
                {
                    string output = "";
                    string dd_ = convert_numeral(dd);
                    string mm_ = convert_numeral(mm);
                    string yy_ = convert_numeral(yy);

                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            output = mm_ + "." + dd_ + "." + yy_;
                            break;

                        case 1:
                            output = dd_ + "." + mm_ + "." + yy_;
                            break;

                        case 2:
                            output = yy_ + "." + mm_ + "." + dd_;
                            break;
                        default:
                            break;
                    }


                    listBox1.Items.Add(convert_numeral(dd));
                    listBox1.Items.Add(convert_numeral(mm));
                    listBox1.Items.Add(convert_numeral(yy));
                }
                else
                {
                    if (!mm_ok)
                        listBox1.Items.Add("Enter a valid month from 1 to 12");
                    if (!dd_ok)
                        listBox1.Items.Add("Enter a valid day from 1 to 31");
                    if (!yy_ok)
                        listBox1.Items.Add("Enter a valid year from 1 to 30999");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("MM.DD.YYYY(US)");
            comboBox1.Items.Add("DD.MM.YYYY(EU)");
            comboBox1.Items.Add("YYYY.MM.DD(ISO)");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add(".(dot)");
            comboBox2.Items.Add("-(line)");
            comboBox2.SelectedIndex = 0;

        }
    }
}
