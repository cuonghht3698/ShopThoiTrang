using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Buniss
{
    public static class ThongTin
    {
        public static int idUser;
        public static string quyen;
        public static string ten;
        public static string quequan;
        public static string sdt;
        public static string usename;
        public static string gioitinh;
        public static string ngaysinh;
        public static string phucap;
        public static string username;
        public static string luongcoban;
    }

    public static class TrangThai
    {
        public static string TaoPhieu = "Đang giao dịch";
        public static string ChoDuyet = "Chờ duyệt";
        public static string DaDuyet = "Đã duyệt";
        public static string GiaoHang = "Giao Hàng";
        public static string HoanThanh = "Hoàn thành";
        public static string DaHuy = "Hủy";
    }

    public static class LoaiPhieu
    {
        public static string NhapKho = "Nhập kho";
        public static string XuatKho = "Xuất kho";
    }

    public static class Role
    {
        public static string admin = "Admin";
        public static string nhanvien = "Nhân viên";
        public static string quanlykho = "Quản lý kho";
        public static string khachhang = "Khách hàng";

    }
}
