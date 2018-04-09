using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using wpg.Infrastructure.Models;

namespace wpg.Infrastructure.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }

    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly WPGContext dbContext;

        public UnitOfWork(WPGContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
