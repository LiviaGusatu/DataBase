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




    }
}
