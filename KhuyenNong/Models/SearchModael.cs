using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.SqlClient;

namespace KhuyenNong.Models
{
    public class SearchModael
    {
        public SearchModael(SqlConnection con)
        {
            this.con = con;
           
        }
        public void search(String keyword, String TbleName)
        {
            String path ="";
            String text = File.ReadAllText(path);

            String sql = @"SELECT * 
                           FROM  + TbleName
                            WHERE TRUE";

            //String connectionString = 
//            SqlConnection con = new SqlConnection();
//            con.ConnectionString = 
//                        @"Data Source=.\SQLEXPRESS;
//                          AttachDbFilename=~\App_Data\database1.mdf;
//                          Integrated Security=True;
//                          Connect Timeout=30;
//                          User Instance=True";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader lst = cmd.ExecuteReader();
                while (lst.Read())
                {

                }
                
            }
            catch { System.Console.WriteLine("Loi xa ra trong SearchModel"); }
           
        }
        SqlConnection con;
    }
}
