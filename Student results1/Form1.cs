using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_results1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intStud1Mod1;
            int intStud1Mod2;
            int intStud1Mod3;
            int intStud1Mod4;
            int intStud1Mod5;
            int intStud1Mod6;
            int intStud1Mod7;
            int intStud1Mod8;
            int intStud1Mod9;
            int intStud1Mod10;
            int intStud2Mod1;
            int intStud2Mod2;
            int intStud2Mod3;
            int intStud2Mod4;
            int intStud2Mod5;
            int intStud2Mod6;
            int intStud2Mod7;
            int intStud2Mod8;
            int intStud2Mod9;
            int intStud2Mod10;
            int intStud3Mod1;
            int intStud3Mod2;
            int intStud3Mod3;
            int intStud3Mod4;
            int intStud3Mod5;
            int intStud3Mod6;
            int intStud3Mod7;
            int intStud3Mod8;
            int intStud3Mod9;
            int intStud3Mod10;
            int intStud4Mod1;
            int intStud4Mod2;
            int intStud4Mod3;
            int intStud4Mod4;
            int intStud4Mod5;
            int intStud4Mod6;
            int intStud4Mod7;
            int intStud4Mod8;
            int intStud4Mod9;
            int intStud4Mod10;
            int intOutput1;
            int intOutput2;
            int intOutput3;
            int intOutput4;
            int intOutput5;
            int intOutput6;
            int intOutput7;
            int intOutput8;
            intStud1Mod1 = int.Parse(txtStd1Mod1.Text);
            intStud1Mod2 = int.Parse(txtStd1Mod2.Text);
            intStud1Mod3 = int.Parse(txtStd1Mod3.Text);
            intStud1Mod4 = int.Parse(txtStd1Mod4.Text);
            intStud1Mod5 = int.Parse(txtStd1Mod5.Text);
            intStud1Mod6 = int.Parse(txtStd1Mod6.Text);
            intStud1Mod7 = int.Parse(txtStd1Mod7.Text);
            intStud1Mod8 = int.Parse(txtStd1Mod8.Text);
            intStud1Mod9 = int.Parse(txtStd1Mod9.Text);
            intStud1Mod10 = int.Parse(txtStd1Mod10.Text);
            intStud2Mod1 = int.Parse(txtStd2Mod1.Text);
            intStud2Mod2 = int.Parse(txtStd2Mod2.Text);
            intStud2Mod3 = int.Parse(txtStd2Mod3.Text);
            intStud2Mod4 = int.Parse(txtStd2Mod4.Text);
            intStud2Mod5 = int.Parse(txtStd2Mod5.Text);
            intStud2Mod6 = int.Parse(txtStd2Mod6.Text);
            intStud2Mod7 = int.Parse(txtStd2Mod7.Text);
            intStud2Mod8 = int.Parse(txtStd2Mod8.Text);
            intStud2Mod9 = int.Parse(txtStd2Mod9.Text);
            intStud2Mod10 = int.Parse(txtStd2Mod10.Text);
            intStud3Mod1 = int.Parse(txtStd3Mod1.Text);
            intStud3Mod2 = int.Parse(txtStd3Mod2.Text);
            intStud3Mod3 = int.Parse(txtStd3Mod3.Text);
            intStud3Mod4 = int.Parse(txtStd3Mod4.Text);
            intStud3Mod5 = int.Parse(txtStd3Mod5.Text);
            intStud3Mod6 = int.Parse(txtStd3Mod6.Text);
            intStud3Mod7 = int.Parse(txtStd3Mod7.Text);
            intStud3Mod8 = int.Parse(txtStd3Mod8.Text);
            intStud3Mod9 = int.Parse(txtStd3Mod9.Text);
            intStud3Mod10 = int.Parse(txtStd3Mod10.Text);
            intStud4Mod1 = int.Parse(txtStd4Mod1.Text);
            intStud4Mod2 = int.Parse(txtStd4Mod2.Text);
            intStud4Mod3 = int.Parse(txtStd4Mod3.Text);
            intStud4Mod4 = int.Parse(txtStd4Mod4.Text);
            intStud4Mod5 = int.Parse(txtStd4Mod5.Text);
            intStud4Mod6 = int.Parse(txtStd4Mod6.Text);
            intStud4Mod7 = int.Parse(txtStd4Mod7.Text);
            intStud4Mod8 = int.Parse(txtStd4Mod8.Text);
            intStud4Mod9 = int.Parse(txtStd4Mod9.Text);
            intStud4Mod10 = int.Parse(txtStd4Mod10.Text);
            intOutput1 = intStud1Mod1 + intStud1Mod2 + intStud1Mod3 + intStud1Mod4 + intStud1Mod5 + intStud1Mod6 + intStud1Mod7 + intStud1Mod8 + intStud1Mod9 + intStud1Mod10;
            intOutput2 = (intStud1Mod1 + intStud1Mod2 + intStud1Mod3 + intStud1Mod4 + intStud1Mod5 + intStud1Mod6 + intStud1Mod7 + intStud1Mod8 + intStud1Mod9 + intStud1Mod10) / 10;
            intOutput3 = intStud2Mod1 + intStud2Mod2 + intStud2Mod3 + intStud2Mod4 + intStud2Mod5 + intStud2Mod6 + intStud2Mod7 + intStud2Mod8 + intStud2Mod9 + intStud2Mod10;
            intOutput4 = (intStud2Mod1 + intStud2Mod2 + intStud2Mod3 + intStud2Mod4 + intStud2Mod5 + intStud2Mod6 + intStud2Mod7 + intStud2Mod8 + intStud2Mod9 + intStud2Mod10) / 10;
            intOutput5 = intStud3Mod1 + intStud3Mod2 + intStud3Mod3 + intStud3Mod4 + intStud3Mod5 + intStud3Mod6 + intStud3Mod7 + intStud3Mod8 + intStud3Mod9 + intStud3Mod10;
            intOutput6 = (intStud3Mod1 + intStud3Mod2 + intStud3Mod3 + intStud3Mod4 + intStud3Mod5 + intStud3Mod6 + intStud3Mod7 + intStud3Mod8 + intStud3Mod9 + intStud3Mod10) / 10;
            intOutput7 = intStud4Mod1 + intStud4Mod2 + intStud4Mod3 + intStud4Mod4 + intStud4Mod5 + intStud4Mod6 + intStud4Mod7 + intStud4Mod8 + intStud4Mod9 + intStud4Mod10;
            intOutput8 = (intStud4Mod1 + intStud4Mod2 + intStud4Mod3 + intStud4Mod4 + intStud4Mod5 + intStud3Mod6 + intStud4Mod7 + intStud4Mod8 + intStud3Mod9 + intStud4Mod10) / 10;
            txtStd1Total.Text = intOutput1.ToString();
            txtStd2Total.Text = intOutput3.ToString();
            txtStd3Total.Text = intOutput5.ToString();
            txtStd4Total.Text = intOutput7.ToString();
            txtStud1Av.Text = intOutput2.ToString();
            txtStud2Av.Text = intOutput4.ToString();
            txtStud3Av.Text = intOutput6.ToString();
            txtStud4Av.Text = intOutput8.ToString();
            string txtInput;
            string strInput;
            int intValue;
            try
            {
                strInput = "txtInput.Text";

                intValue = int.Parse(strInput);
                strInput = intValue.ToString();


                    }
            catch (Exception eXception)
            {
                strInput = "well done";
            }
            MessageBox.Show(strInput);

        }

        private void txtStd1Mod7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
