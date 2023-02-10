using Domain.Interfaces;
using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Interceptors
{

    /// <summary>
    /// Abandon class But For Future Using 
    /// </summary>
    public sealed class UpdateAuditableEntitiesInterceptor : SaveChangesInterceptor
    {
        // private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAuthService _authService;

        public UpdateAuditableEntitiesInterceptor(IAuthService authService)
        {
            //  this._httpContextAccessor = httpContextAccessor;
            this._authService = authService;
        }
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {


            DbContext dbContext = eventData.Context;

            if (dbContext is null)
            {

                return base.SavingChangesAsync(eventData, result, cancellationToken);
            }
            var entries = dbContext.ChangeTracker.Entries<Entity>();
            foreach (EntityEntry<Entity> entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property(a => a.CreatedDate).CurrentValue = DateTime.UtcNow;
                    entityEntry.Property(a => a.CreatedBy).CurrentValue = _authService.GetCurrentLoggedInUser();//_httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value??"test" ;
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property(a => a.ModifiedDate).CurrentValue = DateTime.UtcNow;
                    entityEntry.Property(a => a.ModifiedBy).CurrentValue = _authService.GetCurrentLoggedInUser();// _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value ?? "test";
                }

                if (entityEntry.State == EntityState.Deleted)
                {
                    entityEntry.Property(a => a.DeletedDate).CurrentValue = DateTime.UtcNow;
                    entityEntry.Property(a => a.ModifiedBy).CurrentValue = _authService.GetCurrentLoggedInUser();// _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value ?? "test";

                }
            }
            try
            {
                return base.SavingChangesAsync(eventData, result, cancellationToken);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message);
            }


        }
    }
}
