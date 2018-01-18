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
    [Table("DonVis")]
    public class DonVi:Auditable
    {
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(15)]
        public string MaDonVi { get; set; }

        [MaxLength(256)]
        public string TenDonVi { get; set; }

        public virtual IEnumerable<SuCo> SuCos { get; set; }
    }
}
