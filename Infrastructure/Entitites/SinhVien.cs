using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entitites
{
    [Table("wsSinhVien")]
    public class SinhVien
    {
        [Key]
        public int uID { get; set; }
        public string uMaSv { get; set; }
        public string uHoTen { get; set; }
        public bool uGioiTinh { get; set; }
        public DateTime uNgaySinh { get; set; }
        public string uSoDienThoai { get; set; }
        public string uMaSoSinhVien { get; set; }
    }
}
