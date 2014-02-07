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
    public partial class Form1 : Form
    {
        
        
        public Form1( string _user)
        {
            
            InitializeComponent();
            label4.Text = _user;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        BusinessLayer bs = new BusinessLayer();

       
          private void button1_Click_1(object sender, EventArgs e)
        {
            //mai multi destinatari

            Catre2.Visible = true;
            Catre3.Visible = true;

            MessageBox.Show("Numarul maxim de destinatari este 3!");

        }

          MessContClass mcc = new MessContClass();

        private void button2_Click_1(object sender, EventArgs e)
        {
            //buton trimitere mesaj
            DateTime savenow = DateTime.Now;
            int userid = bs.returnbl(label4.Text);

            
            if (Catre1.Text.Length == 0 && Catre2.Visible == false && Catre3.Visible == false)
                MessageBox.Show("Lipsa destinatar");
            if (Catre1.Text.Length == 0 && Catre2.Text.Length == 0 && Catre3.Text.Length == 0 && Catre2.Visible==true && Catre3.Visible==true)
                MessageBox.Show("Lipsa destinatar!");
            if (Catre1.Text.Length == 0)
            {
                
            }
            else
            {
                bs.insertmessbl(label4.Text, Catre1.Text, Subiect.Text, Mesaj.Text, savenow, userid);
                MessageBox.Show("Message sent to " + Catre1.Text + " !");
            }

            if (Catre2.Visible == true)
            {
                if (Catre2.Text.Length == 0) 
                {
                   
                }
                else
                {
                    bs.insertmessbl(label4.Text, Catre2.Text, Subiect.Text, Mesaj.Text, savenow, userid);
                    MessageBox.Show("Message sent to " + Catre2.Text + " !");
                }
            }

            if (Catre3.Visible == true)
            {
                if (Catre3.Text.Length == 0)
                {
                   
                }
                else
                {
                    bs.insertmessbl(label4.Text, Catre3.Text, Subiect.Text, Mesaj.Text, savenow, userid);
                    MessageBox.Show("Message sent to " + Catre3.Text+" !");
                }
            }


        }

        
    

        
    }
}
