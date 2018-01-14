using BaoCaoSuCo.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Model.Models
{
    [Table("SuCos")]
    public class SuCo:Auditable
    {
        public int ID { set; get; }

        public int SoBaoCao { get; set; }
        public string MaDonVi { get; set; }
        public  string  HoTenBenhNhan { get; set; }
        public int SoBenhAn { get; set; }
        public DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public int DoiTuong { get; set; }
        public int LoaiBaoCao { get; set; }
        public string NoiXayRa { get; set; }
        public string ViTri { get; set; }
        public DateTime NgayXayRa { get; set; }
        public string MoTo { get; set; }
        public string DeXuatGiaiPhap { get; set; }
        public string XuLiBanDau { get; set; }
        public int ThongBaoBacSi { get; set; }
        public int ThongBaoNguoiNha { get; set; }
        public int GhiNhanHoSo { get; set; }
        public int ThongBaoBenhNhan { get; set; }
        public int PhanLoaiBanDau { get; set; }
        public int MucDoAnhHuong { get; set; }

        public string HoTenNguoiBaoCao { get; set; }
        public int SoDienThoai { get; set; }
        public string Email { get; set; }
        public int ChucVu { get; set; }
        public string ChucDanh { get; set; }
        public string Khac { get; set; }

        public string NguoiChungKien1 { get; set; }
        public string NguoiChungKien2 { get; set; }

        public int TrangThai { get; set; }
    }
}
