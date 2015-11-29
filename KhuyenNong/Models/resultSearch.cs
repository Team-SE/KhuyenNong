using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhuyenNong.Models
{
    public class resultSearch
    {
        public String Title {get; set;}
        public String Contains{get; set;}
        public String Author{get; set;}
        public String DateWritten{get; set;}
        public String Id{get; set;}
        public resultSearch(string tt, string ct, string au, string d, string id)
        {
            this.Title = tt;
            this.Contains = ct;
            this.Author = au;
            this.DateWritten = d;
            this.Id = id;
        }
        public resultSearch() { }
        public String displaySerch()
        {
            String title = "<h3><a href=\"#\" style=\"color:blue\">" + Title.ToString() + "</a></h3> <br/>";
            String contains = "<h5>" + Contains.Substring(0, 256) + "... <br/>... </h5>";
            String author = "<h4><b>" + Author + "</b></h4>";
            String res = title + contains + author;
            return res;
        }
    }
}