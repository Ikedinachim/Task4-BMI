using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String comment = "";
            int bmi = Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
           if(bmi < 18.5){
                comment = "You are underweight";
            }
           else if(bmi < 25)
            {
                comment = "You have a normal weight";
            
            }else if( bmi < 30)
            {
                comment = "You are overweight";
            }else if(bmi >= 30){
                comment = "You are obese";
            }
            else
            {
                comment = "invalid entry";
            }
            textBox3.Text = Convert.ToString(bmi);
            textBox4.Text = comment;

           

        }
    }
}
