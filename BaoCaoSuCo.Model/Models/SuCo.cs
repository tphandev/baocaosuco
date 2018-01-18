using BaoCaoSuCo.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Model.Models
{
    [Table("SuCos")]
    public class SuCo:Auditable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { set; get; }
       
        public int SoBaoCao { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(15)]
        public string MaDonVi { get; set; }

        [Required]
        [MaxLength(256)]
        public  string  HoTenBenhNhan { get; set; }

        public int SoBenhAn { get; set; }

       
        public DateTime NgaySinh { get; set; }

       
        public int GioiTinh { get; set; }
   
        public int DoiTuong { get; set; }
     
        public int LoaiBaoCao { get; set; }

        [Required]
        [MaxLength(500)]
        public string NoiXayRa { get; set; }

        [Required]
        [MaxLength(500)]
        public string ViTri { get; set; }

    
        public DateTime NgayXayRa { get; set; }

        [Required]
        public string MoTo { get; set; }

        [Required]
        public string DeXuatGiaiPhap { get; set; }

        [Required]
        public string XuLiBanDau { get; set; }

       
        public int ThongBaoBacSi { get; set; }
    
        public int ThongBaoNguoiNha { get; set; }
       
        public int GhiNhanHoSo { get; set; }
      
        public int ThongBaoBenhNhan { get; set; }
        
        public int PhanLoaiBanDau { get; set; }
       
        public int MucDoAnhHuong { get; set; }

        [MaxLength(256)]
        public string HoTenNguoiBaoCao { get; set; }

        [MaxLength(20)]
        public string SoDienThoai { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public int ChucVu { get; set; }
        [MaxLength(256)]
        public string ChucDanh { get; set; }
        [MaxLength(256)]
        public string Khac { get; set; }
        [MaxLength(256)]
        public string NguoiChungKien1 { get; set; }
        [MaxLength(256)]
        public string NguoiChungKien2 { get; set; }

           
        public int TrangThai { get; set; }

        [ForeignKey("MaDonVi")]
        public virtual DonVi DonVi { get; set; }
    }
}
