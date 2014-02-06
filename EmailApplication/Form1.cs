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
        
        
        public Form1(string _user)
        {
            
            InitializeComponent();
            label4.Text = _user;

            
        }

        
    }
}
