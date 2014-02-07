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

        public void set_MSGID(int a)
        {
            objdal.set_mesID(a);
        }

        public int getMSGID()
        {
            return objdal.get_mesID();
        }

        public void set_SRS(string a)
        {
            objdal.set_srs(a);
        }

        public string getSRS()
        {
            return objdal.get_srs();
        }

        public void set_DST(string a)
        {
            objdal.set_dst(a);
        }

        public string getDST()
        {
            return objdal.get_dst();
        }

        public void set_SBJ(string a)
        {
            objdal.set_sbj(a);
        }

        public string getSBJ()
        {
            return objdal.get_sbjs();
        }

        public void set_CONT(string a)
        {
            objdal.set_content(a);
        }

        public string getCONT()
        {
            return objdal.get_content();
        }

        public void set_DATA(DateTime a)
        {
            objdal.set_data(a);
        }

        public DateTime getDATA()
        {
            return objdal.get_data();
        }

        public void insertmessbl(string source, string dest, string subj, string cont, DateTime data,int userid)
        {
            objdal.insertMessage(source,dest,subj,cont,data,userid);
        }

        public int returnbl(string text)
        {
            return objdal.returnid(text);
        }
    }
}
