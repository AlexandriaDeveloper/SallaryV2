using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeCollections.Queries.GetEmployeeListCollection
{
    public class GetEmployeeListCollectionQuerySpecification : Specification<EmployeeCollection>
    {

        public GetEmployeeListCollectionQuerySpecification(int collectionId)
        {
            AddCriteries(x => x.CollectionId == collectionId);
            AddInclude(x => x.Employee);
            AddOrderBy(x => x.EmployeeOrderInCollection);
        }


    }



}
