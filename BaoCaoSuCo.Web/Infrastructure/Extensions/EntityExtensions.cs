using BaoCaoSuCo.Model.Models;
using BaoCaoSuCo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCaoSuCo.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateSuCo(this SuCo suCo, SuCoViewModel suCoVm)
        {
            suCo.ChucDanh = suCoVm.ChucDanh;
            suCo.ChucVu = suCoVm.ChucVu;
            suCo.DeXuatGiaiPhap = suCoVm.DeXuatGiaiPhap;
            suCo.DoiTuong = suCoVm.DoiTuong;
            suCo.Email = suCoVm.Email;
            suCo.GhiNhanHoSo = suCoVm.GhiNhanHoSo;
            suCo.GioiTinh = suCoVm.GioiTinh;
            suCo.HoTenBenhNhan = suCoVm.HoTenBenhNhan;
            suCo.HoTenNguoiBaoCao = suCoVm.HoTenNguoiBaoCao;
            suCo.ID = suCoVm.ID;
            suCo.Khac = suCoVm.Khac;
            suCo.LoaiBaoCao = suCoVm.LoaiBaoCao;
            suCo.MaDonVi = suCoVm.MaDonVi;
            suCo.MoTa = suCoVm.MoTa;
            suCo.MucDoAnhHuong = suCoVm.MucDoAnhHuong;
            suCo.NgayCapNhat = suCoVm.NgayCapNhat;
            suCo.NgaySinh = suCoVm.NgaySinh;
            suCo.NgayTao = suCoVm.NgayTao;
            suCo.NgayXayRa = suCoVm.NgayXayRa;
            suCo.NguoiCapNhat = suCoVm.NguoiCapNhat;
            suCo.NguoiChungKien1 = suCoVm.NguoiChungKien1;
            suCo.NguoiChungKien2 = suCoVm.NguoiChungKien2;
            suCo.NguoiTao = suCoVm.NguoiTao;
            suCo.NoiXayRa = suCoVm.NoiXayRa;
            suCo.PhanLoaiBanDau = suCoVm.PhanLoaiBanDau;
            suCo.SoBaoCao = suCoVm.SoBaoCao;
            suCo.SoBenhAn = suCoVm.SoBenhAn;
            suCo.SoDienThoai = suCoVm.SoDienThoai;
            suCo.ThongBaoBacSi = suCoVm.ThongBaoBacSi;
            suCo.ThongBaoBenhNhan = suCoVm.ThongBaoBenhNhan;
            suCo.ThongBaoNguoiNha = suCoVm.ThongBaoNguoiNha;
            suCo.TrangThai = suCoVm.TrangThai;
            suCo.ViTri = suCoVm.ViTri;
            suCo.xoa = suCoVm.xoa;
            suCo.XuLiBanDau = suCoVm.XuLiBanDau;
            
        }

        public static void UpdateDonVi(this DonVi donVi, DonViViewModel donViVM)
        {
            donVi.MaDonVi = donViVM.MaDonVi;
            donVi.TenDonVi = donViVM.TenDonVi;
            donVi.NgayCapNhat = donViVM.NgayCapNhat;
            donVi.NguoiCapNhat = donViVM.NguoiCapNhat;
            donVi.NgayTao = donViVM.NgayTao;
            donVi.NguoiTao = donViVM.NguoiTao;
            donVi.xoa = donViVM.xoa;


        }
    }
}