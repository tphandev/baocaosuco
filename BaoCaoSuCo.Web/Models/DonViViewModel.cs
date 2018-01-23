using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCaoSuCo.Web.Models
{
    public class DonViViewModel
    {
        public string MaDonVi { get; set; }

        public string TenDonVi { get; set; }

        public virtual IEnumerable<SuCoViewModel> SuCos { get; set; }

        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool xoa { get; set; }
    }
}