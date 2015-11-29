using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhuyenNong.Models
{
    public class rowSearch
    {
        public String Title {get; set;}
        public String Contains{get; set;}
        public String Author{get; set;}
        public String DateWritten{get; set;}
        public String Id{get; set;}
        public rowSearch(string tt, string ct, string au, string d, string id)
        {
            this.Title = tt;
            this.Contains = ct;
            this.Author = au;
            this.DateWritten = d;
            this.Id = id;
        }
        public rowSearch() { }
    }
}