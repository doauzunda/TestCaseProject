
using ProjectTry.Coree.Interfaces;



namespace ProjectTry.Infrastructuree.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DbContextClass _dbContext;
        public IProductRepository Products { get; }
        public ICategoryRepository Categories { get; }

        public UnitOfWork(DbContextClass dbContext,
                            IProductRepository productRepository,
                            ICategoryRepository categoryRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
            Categories = categoryRepository;  
        }

       

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
