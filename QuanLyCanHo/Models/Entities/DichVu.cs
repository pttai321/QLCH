using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCanHo.Models.Entities
{
    public partial class DichVu
    {
        [Key]
        [StringLength(10)]
        [Required(ErrorMessage = "Không được để trống Mã Dịch Vụ")]
        public string MaDichVu { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Không được để trống Tên Dịch Vụ")]
        public string TenDichVu { get; set; }

        [Required(ErrorMessage = "Không được để trống Giá Dịch Vụ")]
        public int? GiaDichVu { get; set; }
    }
}