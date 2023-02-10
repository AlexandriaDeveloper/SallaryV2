using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Form.Queries.FormList
{
    public record FormListQuery(FormListQueryParam formParam) : IQuery<PagedList<FormDto>>;
    public class FormListQueryHandler : IQueryHandler<FormListQuery, PagedList<FormDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public FormListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<FormDto>>> Handle(FormListQuery request, CancellationToken cancellationToken)
        {
            FormListQuerySpecification spec = new FormListQuerySpecification(request.formParam);
            var formsFromDb = await _uow.FormRepository.GetAllBySpecAsync(spec);
            if (formsFromDb == null)
            {
                return Result<PagedList<FormDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var formToReturn = _mapper.Map<PagedList<FormDto>>(formsFromDb);

            return Result
                .Success(formToReturn);
        }
    }
    public class FormListQuerySpecification : Specification<Domain.Models.Form>
    {
        public FormListQuerySpecification(FormListQueryParam param)
        {
            ApplyPaging(param.pageIndex, param.PageSize);

        }
    }

    public class FormListQueryParam : Param
    {
    }
}
