using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailApplication
{
    public partial class StartUp : Form
    {
        public string user;
        public StartUp()
        {
            
            InitializeComponent();
            
            
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLayer bl=new BusinessLayer();

            int result=bl.checkidentitybl(textBox1.Text,textBox2.Text);

            if (result > 0)
            {
                Form1 m = new Form1(textBox1.Text);
                
                this.Hide();
                m.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Username or password wrong! Please retry");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp a = new SignUp();
            a.Show();
            textBox1.Clear();
            textBox2.Clear();
        }

        public string getuser()
        {
            return textBox1.Text;

        }


    }
}
