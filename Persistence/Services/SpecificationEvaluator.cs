using Domain.DTOS;
using Domain.Interfaces;
using Domain.Primitives;
using Domain.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace Persistence.Services
{
    public class SpecificationEvaluator<TEntity> where TEntity : Entity
    {
        public static async Task<PagedList<TEntity>> GetQuery(IQueryable<TEntity> inputQuery, bool trackingChange, ISpecification<TEntity> spec)
        {
            IPagination pagination = null;

            var query = inputQuery;
            //query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
            if (!trackingChange)
            {
                query = query.AsNoTracking();
            }
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            if (spec.Criteries.Count > 0)
            {
                foreach (var criteria in spec.Criteries)
                {
                    query = query.Where(criteria);
                }
            }


            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);

            }
            if (spec.OrderByDescending != null)
            {
                query = query.OrderByDescending(spec.OrderByDescending);
            }

            if (spec.IsPagination)
            {
                pagination = new Pagination() { Length = await query.CountAsync(), PageIndx = spec.PageIndex, PageSize = spec.PageSize };

                // if (spec.OrderBy == null && spec.OrderByDescending == null)

                //      query = query.OrderBy(x => x.Id).Skip(pagination.PageIndx*pagination.PageSize).Take(pagination.PageSize);
                //  else
                //   {
                query = query.Skip(pagination.PageIndx * pagination.PageSize).Take(pagination.PageSize);
                //  }



            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return new PagedList<TEntity>(query.ToList(), pagination);
        }



    }
}
