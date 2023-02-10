using Domain.Interfaces;
using Domain.Primitives;
using Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;
        private readonly DbSet<T> _dbSet;

        public Repository(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
            this._dbSet = context.Set<T>();

        }
        public async Task AddItem(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.CreatedDate = DateTime.UtcNow;
            entity.CreatedBy = _authService.GetCurrentLoggedInUser();
            await _dbSet.AddAsync(entity);

        }

        public async Task Delete(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            if (entity.IsDeleted)
            {
                throw new Exception("Not Found");
            }
            entity.DeletedDate = DateTime.Now;
            entity.DeletedBy = _authService.GetCurrentLoggedInUser();
            _dbSet.Update(entity);

        }
        public async Task HardDelete(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            if (entity.IsDeleted)
            {
                throw new Exception("Not Found");
            }

            _dbSet.Remove(entity);

        }
        public async Task<int?> Next(Expression<Func<T, int>> orderBy, int id)
        {
            var ids = await _dbSet.Where(x => x.Id > id && x.DeletedDate == null).OrderBy(orderBy).Select(x => x.Id).FirstOrDefaultAsync();
            return ids;
        }
        public async Task<int?> Previous(Expression<Func<T, int>> orderBy, int id)
        {
            var ids = await _dbSet.Where(x => x.Id < id && x.DeletedDate == null).OrderByDescending(orderBy).Select(x => x.Id).FirstOrDefaultAsync();
            return ids;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbSet.Where(x => x.DeletedDate == null).ToListAsync();
        }
        public async Task<PagedList<T>> GetAllBySpecAsync(ISpecification<T>? spec = null, bool trackChanges = true)
        {

            return await ApplySpecification(spec, trackChanges);
        }
        public async Task<bool> CheckExistAsync(int id)
        {

            return await _dbSet.AnyAsync(x => x.Id == id);
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }
        public async Task<T?> GetByNameAsync(string name)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Name.Equals(name));
        }
        public async Task<T?> GetByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.SingleOrDefaultAsync(expression);
        }
        public async Task<List<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }
        public bool CheckByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Any(expression);
        }
        public async Task<T> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null, bool trackChanges = true)
        {
            var result = await ApplySpecification(spec, trackChanges);
            return result.Data.FirstOrDefault();
        }

        public Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.ModifiedDate = DateTime.UtcNow;
            entity.ModifiedBy = _authService.GetCurrentLoggedInUser();
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }
        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            var list = await ApplySpecification(spec);

            return list.Data.Count();
        }

        private Task<PagedList<T>> ApplySpecification(ISpecification<T> spec, bool trackingChanges = true)

        {
            spec.Criteries.Add(x => x.DeletedDate == null);
            return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), trackingChanges, spec); ;
        }
        public async Task<PagedList<T>> GetAlDeletedlAsync(ISpecification<T>? spec = null, bool trackingChanges = true)
        {

            return await ApplyDeletedSpecification(trackingChanges, spec);

        }
        public async Task Restore(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity == null)
                throw new ArgumentNullException();
            if (!entity.IsDeleted)
            {
                throw new Exception("Not Found");
            }
            entity.DeletedDate = null;
            entity.DeletedBy = null;
            _dbSet.Update(entity);

        }
        private Task<PagedList<T>> ApplyDeletedSpecification(bool trackingChanges, ISpecification<T> spec)
        {
            spec.Criteries.Add(x => x.DeletedDate != null);
            return SpecificationEvaluator<T>.GetQuery(_dbSet.AsQueryable(), trackingChanges, spec); ;
        }


    }
}
