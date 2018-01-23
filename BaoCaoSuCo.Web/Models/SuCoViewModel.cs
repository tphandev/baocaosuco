using System;

namespace BaoCaoSuCo.Web.Models
{
    public class SuCoViewModel
    {
        public int ID { set; get; }

        public int SoBaoCao { get; set; }

        public string MaDonVi { get; set; }

        public string HoTenBenhNhan { get; set; }

        public int SoBenhAn { get; set; }

        public DateTime NgaySinh { get; set; }

        public int GioiTinh { get; set; }

        public int DoiTuong { get; set; }

        public int LoaiBaoCao { get; set; }

        public string NoiXayRa { get; set; }

        public string ViTri { get; set; }

        public DateTime NgayXayRa { get; set; }

        public string MoTa { get; set; }

        public string DeXuatGiaiPhap { get; set; }

        public string XuLiBanDau { get; set; }

        public int ThongBaoBacSi { get; set; }

        public int ThongBaoNguoiNha { get; set; }

        public int GhiNhanHoSo { get; set; }

        public int ThongBaoBenhNhan { get; set; }

        public int PhanLoaiBanDau { get; set; }

        public int MucDoAnhHuong { get; set; }

        public string HoTenNguoiBaoCao { get; set; }

        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int ChucVu { get; set; }
        public string ChucDanh { get; set; }
        public string Khac { get; set; }
        public string NguoiChungKien1 { get; set; }
        public string NguoiChungKien2 { get; set; }

        public int TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }


        public virtual DonViViewModel DonVi { get; set; }
    }
}