using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLKH.Models
{
    [Table ("TaiKhoanNV")]
    public class TaiKhoanNV
    {
        [Key]
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public int SDT { get; set; }


    }
}