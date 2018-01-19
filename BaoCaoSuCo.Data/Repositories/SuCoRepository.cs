using BaoCaoSuCo.Data.Infrastructure;
using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Data.Repositories
{
    public interface ISuCoRepository : IRepository<SuCo>
    {

    }
    public class SuCoRepository : RepositoryBase<SuCo>,ISuCoRepository
    {
        public SuCoRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
