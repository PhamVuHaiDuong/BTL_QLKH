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
    [Table ("HangHoa")]
    public class HangHoa
    {
        [Key]
        [StringLength(50)]
        [DisplayName ("Mã Hàng Hóa")]
        public string MaHH { get; set; }
        [StringLength(50)]
        [DisplayName("Tên Hàng Hóa")]
        public string TenHH { get; set; }
        [DisplayName("Đơn Giá")]
        public int DonGia { get; set; }
        [StringLength(10)]
        [DisplayName("Đơn vị tính")]
        public string DV { get; set; }
    }
}