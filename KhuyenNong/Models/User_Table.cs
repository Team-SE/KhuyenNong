﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhuyenNong.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class User_Table
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Không được để trống email", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength=3, ErrorMessage="Quá nhiều kí tự")]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Quá nhiều kí tự")]
        public string username { get; set; }

        [Required(ErrorMessage = "Không được để trống email", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Quá nhiều kí tự")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string password { get; set; }
        public int level { get; set; }
    }
}
