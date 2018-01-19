﻿using BaoCaoSuCo.Data.Infrastructure;
using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Data.Repositories
{
    public class DonViRepository : RepositoryBase<DonVi>
    {
        public DonViRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
