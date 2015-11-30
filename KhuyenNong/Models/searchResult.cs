using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhuyenNong.Models
{
    public class searchResult
    {
        public List<rowSearch> row;
        public string keysword;
        public searchResult(List<rowSearch> r, string k)
        {
            this.row = r;
            this.keysword = k;
        }
    }
}