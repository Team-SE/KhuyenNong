using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhuyenNong.Models.HomePage
{
    public class resSearch
    {
        public List<thumbHome> list;
        public string keys;
        public resSearch(List<thumbHome> l, string k)
        {
            list = l;
            keys = k;
        }
    }
}