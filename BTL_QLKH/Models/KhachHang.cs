using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;

namespace BTL_QLKH.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [DisplayName("Mã Khách Hàng")]
        public string MaKH { get; set; }
        [DisplayName("Tên Khách Hàng")]
        public string TenKH { get; set; }
        [DisplayName("Số điện thoại")]
        [StringLength(10)]
        public string SDT { get; set; }
        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }
        [Column(TypeName = "date")]
        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }
    }
}