using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApplication
{
    class BusinessLayer
    {
        DataLayer objdal = new DataLayer();

        public int checkidentitybl(string text1,string text2)
        {
            return objdal.checkidentity(text1,text2);
        }

        public int checkuserbl(string text)
        {
            return objdal.usernameexist(text);
        }

        public void insertbl(string user, string pass)
        {
            objdal.insertaccount(user, pass);
        }


    }
}
