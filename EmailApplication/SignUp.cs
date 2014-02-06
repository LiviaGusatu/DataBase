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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = new BusinessLayer();
            int result = bl.checkuserbl(textBox1.Text);

            if (result > 0)
            {
                MessageBox.Show("Username already in database! Please choose another");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

            else if (textBox1.Text.Length == 0)
                MessageBox.Show("Completati toate campurile");
            else if (textBox2.Text.Length == 0)
                MessageBox.Show("Completati toate campurile");
            else if (textBox3.Text.Length == 0)
                MessageBox.Show("Completati toate campurile");
            else if (textBox3.Text.Length <= 6)
            {
                MessageBox.Show("Password too week!\n Password should contain at least 6 characters");
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password too week!\n Password should contain at least 6 characters");
                textBox2.Clear();
                textBox3.Clear();
            }

            else
            {
                bl.insertbl(textBox1.Text, textBox2.Text);
                MessageBox.Show("Userul a fost inserat cu succes in baza de date");
                this.Close();
            }

           
            

             
        }
    }
}
