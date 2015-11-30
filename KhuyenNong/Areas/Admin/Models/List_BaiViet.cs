using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhuyenNong.Areas.Admin.Models {
    public class List_BaiViet {
        public static List<BaiViet> Baiviet_List = new List<BaiViet>() {
            new BaiViet{title="Tiêu đề 1",date="Ngay 1",content="Admin1"},
            new BaiViet{title="Tiêu đề 2",date="Ngay 2",content="Admin2"}
        };

        public static void Add(BaiViet a) {
            Baiviet_List.Add(a);
        }
    }
}