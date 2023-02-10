using Domain.Interfaces;
using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Persistence.Services
{
    internal class Specification<T> : ISpecification<T> where T : Entity
    {
        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, bool>>> Criteries { get; } = new List<Expression<Func<T, bool>>>();
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }
        public int Take { get; private set; }
        public int Skip { get; private set; }
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }

        public bool IsPagination { get; private set; } = false;
        public Specification()
        {

        }
        public Specification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }


        protected void AddCriteries(Expression<Func<T, bool>> criteria)
        {
            this.Criteries.Add(criteria);
        }
        protected void AddInclude(Expression<Func<T, object>> include)
        {
            this.Includes.Add(include);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }

        protected void ApplyPaging(int skip, int take, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Skip = skip;
            Take = take;
            IsPagination = true;
        }
    }
}
