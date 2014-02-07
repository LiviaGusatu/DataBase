using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;





namespace EmailApplication
{
    class DataLayer
    {
        public static int n = 3;
        public string Encrypt(string parola)
        {
            byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(parola);
            string nou = Convert.ToBase64String(passBytes);
            return nou;
        }

        public int checkidentity(string text1,string text2)
        {
        SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source=(local);Initial Catalog=AplicatieEmail;Integrated Security=True");
            sc.Open();
            com.Connection = sc;
            com.CommandText = (" SELECT COUNT(*) FROM Users WHERE (UserName = @Username) AND (Password = @Password)");

            com.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));


            com.Parameters["@Username"].Value = text1;
            com.Parameters["@Password"].Value = Encrypt(text2);

            int result =(int) com.ExecuteScalar();
            return result ;

             }


        public int usernameexist(string text)
        {
            SqlConnection sc2 = new SqlConnection();
            SqlCommand com2 = new SqlCommand();
            sc2.ConnectionString = ("Data Source=(local);Initial Catalog=AplicatieEmail;Integrated Security=True");
            sc2.Open();
            com2.Connection = sc2;
            com2.CommandText = (" SELECT COUNT(*) FROM Users WHERE (UserName = @Username) ");

            com2.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50));

            com2.Parameters["@Username"].Value = text;

            int result = (int)com2.ExecuteScalar();
            return result;

        }

        public void insertaccount(string user, string pass)
        {
            SqlConnection sc = new SqlConnection();
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source=(local);Initial Catalog=AplicatieEmail;Integrated Security=True");
            sc.Open();
            com.Connection = sc;
            com.CommandText = (" INSERT INTO Users (Username, Password,RoleID) VALUES (@Username,@Password,@RoleID)");

            com.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@RoleID", SqlDbType.Int));

            com.Parameters["@Username"].Value = user;
            com.Parameters["@Password"].Value = Encrypt(pass);
            com.Parameters["@RoleID"].Value = "2";


            com.ExecuteNonQuery();
        }

        public DBConnection initDB()
        {
            DBConnection db = new DBConnection();

            //db.UserName = "sa";
            //db.Password = "administrator";
            db.ServerName = "LIVIA-PC\\SQLEXPRESS";
            db.DatabaseName = "AplicatieEmail";

            return db;
        }

        MessContClass MC = new MessContClass();

        public void set_mesID(int a)
        {
            MC.MessageID = a;
        }

        public int get_mesID()
        {
            return MC.MessageID;
        }

        public void set_srs(string a)
        {
            MC.Source = a;
        }

        public string get_srs()
        {
            return MC.Source;
        }

        public void set_dst(string a)
        {
            MC.Destination = a;
        }

        public string get_dst()
        {
            return MC.Destination;
        }

        public void set_sbj(string a)
        {
            MC.Subject = a;
        }

        public string get_sbjs()
        {
            return MC.Subject;
        }

        public void set_content(string a)
        {
            MC.ContentM = a;
        }

        public string get_content()
        {
            return MC.ContentM;
        }

        public void set_data(DateTime a)
        {
            MC.Data = a;
        }

        public DateTime get_data()
        {
            return MC.Data;
        }

        public void insertMessage(string source,string dest,string subj,string cont,DateTime data,int userid)
        {
            

            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = ("Data Source=(local);Initial Catalog=AplicatieEmail;Integrated Security=True");
            sc.Open();
            SqlCommand com2 = new SqlCommand();
            com2.Connection = sc;
            com2.CommandText = (" INSERT INTO Messages (Type,ReadM,UserID) VALUES (@Type,@ReadM,@UserID)");
            
            //com2.Parameters.Add(new SqlParameter("@MessageID", SqlDbType.Int));
            com2.Parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar, 50));
            com2.Parameters.Add(new SqlParameter("@ReadM", SqlDbType.NVarChar,50));
            com2.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int));

            //com2.Parameters["@MessageID"].Value = "6";
            com2.Parameters["@Type"].Value = "Outbox";
            com2.Parameters["@ReadM"].Value = "Unread";
            com2.Parameters["@UserID"].Value = userid;

            com2.ExecuteNonQuery();

            SqlCommand com = new SqlCommand();
            
            com.Connection = sc;
            com.CommandText = (" INSERT INTO MessageContent (Source,Destination,Subject,ContentM,Data) VALUES (@Source,@Destination,@Subject,@ContentM,@Data)");
            
            //com.Parameters.Add(new SqlParameter("@MessageID", SqlDbType.Int));
            com.Parameters.Add(new SqlParameter("@Source", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@Destination", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@Subject", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@ContentM", SqlDbType.NVarChar, 50));
            com.Parameters.Add(new SqlParameter("@Data", SqlDbType.DateTime));

           // com.Parameters["@MessageID"].Value ="6";
            com.Parameters["@Source"].Value = source;
            com.Parameters["@Destination"].Value = dest;
            com.Parameters["@Subject"].Value = subj;
            com.Parameters["@ContentM"].Value = cont;
            com.Parameters["@Data"].Value = data;
            
            com.ExecuteNonQuery();
            n++;
            
                       

        }

        public int returnid(string text)
        {
            SqlConnection sc2 = new SqlConnection();
            SqlCommand com2 = new SqlCommand();
            sc2.ConnectionString = ("Data Source=(local);Initial Catalog=AplicatieEmail;Integrated Security=True");
            sc2.Open();
            com2.Connection = sc2;
            com2.CommandText = (" SELECT UserID FROM Users WHERE (UserName = @Username) ");

            com2.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50));

            com2.Parameters["@Username"].Value = text;

            int result = (int)com2.ExecuteScalar();
            return result;
        }





    }
}
