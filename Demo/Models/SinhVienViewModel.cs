using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class SinhVienViewModel
    {
        public SinhVienViewModel()
        {
        }

        [DisplayName("ID")]
        public int uID { get; set; }

        [DisplayName("Mã sinh viên")]
        [MaxLength(10, ErrorMessage = "Mã sinh viên không quá 10 ký tự.")]
        public string uMaSv { get; set; }

        [DisplayName("Họ và tên")]
        [MaxLength(100, ErrorMessage = "Họ và tên không quá 100 ký tự.")]
        public string uHoTen { get; set; }

        [DisplayName("Giới tính")]
        public bool uGioiTinh { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime uNgaySinh { get; set; }

        [DisplayName("Điện thoại")]
        [MaxLength(10, ErrorMessage = "Điện thoại không quá 10 ký tự.")]
        public string uSoDienThoai { get; set; }

        [DisplayName("Địa chỉ")]
        [MaxLength(1000, ErrorMessage = "Đỉa chỉ không quá 1000 ký tự.")]
        public string uDiaChi { get; set; }
    }
}
