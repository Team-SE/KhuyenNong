using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.SqlClient;

namespace KhuyenNong.Models
{
    public class SearchModel1
    {
        public SearchModel1(SqlConnection con)
        {
            this.con = con;

        }
        public SearchModel1()
        {
            //String connectionString = 
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                        "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + "~/App_Data/Database1.mdf"
                        + ";Integrated Security=True";
            this.con = con;
        }
        public String search(String keyword, String TbleName)
        {
            String sql = @"SELECT * 
                           FROM  + TbleName
                            WHERE TRUE";
            //using (Database1 )

            try
            {
                this.con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader lst = cmd.ExecuteReader();
                List<resultSearch> result = new List<resultSearch>();

                while (lst.Read())
                {
                    String id = lst[0].ToString();
                    String title = lst[1].ToString();
                    String contanins = lst[2].ToString();
                    String author = lst[3].ToString();

                    // string path = "";
                    String text = File.ReadAllText(contanins);
                    if (title.Contains(keyword) || contanins.Contains(keyword))
                    {
                        resultSearch res = new resultSearch();
                        res.Id = id;
                        res.Title = title;
                        res.Contains = text;
                        res.Author = author;

                        result.Add(res);

                    }
                }

                String htmlContant = "";
                foreach (var i in result)
                {
                    htmlContant += i.displaySerch();
                }
                con.Close();
                return htmlContant;
            }
            catch(Exception e)
            {
                try { con.Close(); }
                catch { }
                System.Console.WriteLine("Loi xa ra trong SearchModel");
                return "Lỗi xảy ra trong kết nối dữ liệu <br/>" + e.Message;
            }
           
        }

        public String Search(String keyword, String tblename)
        {
            using (Database1Entities db = new Database1Entities())
            {

            }
            return "";
        }
        SqlConnection con;
    }
}
