using System;

namespace BaoCaoSuCo.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BaoCaoSuCoDbContext Init();
    }
}