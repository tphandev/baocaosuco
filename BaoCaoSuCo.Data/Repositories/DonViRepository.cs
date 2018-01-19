using BaoCaoSuCo.Data.Infrastructure;
using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Data.Repositories
{
    public interface IDonViRepository:IRepository<DonVi>
    {

    }
    public class DonViRepository : RepositoryBase<DonVi>,IDonViRepository
    {
        public DonViRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
