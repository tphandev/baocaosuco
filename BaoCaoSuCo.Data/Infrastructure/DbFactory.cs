namespace BaoCaoSuCo.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BaoCaoSuCoDbContext dbContext;

        public BaoCaoSuCoDbContext Init()
        {
            return dbContext ?? (dbContext = new BaoCaoSuCoDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}