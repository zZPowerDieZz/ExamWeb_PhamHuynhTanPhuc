using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_PhamHuynhTanPhuc.Models
{
    public class DiaNhac
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tựa CD"), StringLength(250)]
        public string TieuDe { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên ca sĩ"), StringLength(50)]
        public string NgheSi { get; set; }
        public bool TrongNuoc { get; set; }
        [Range(1,9999999999,ErrorMessage = "Giá bán không được nhỏ hơn 0 (<0)")]
        public double GiaBan { get; set; }
        [Range(1, 1000, ErrorMessage = "Số lượng không được nhỏ hơn 0 (<0)")]
        public int SoLuong { get; set; }
    }
}
