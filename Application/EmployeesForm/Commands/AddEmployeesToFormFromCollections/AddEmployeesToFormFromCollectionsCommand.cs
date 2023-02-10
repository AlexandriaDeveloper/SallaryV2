using Application.Common.Messaging;
using Application.EmployeeCollections.Queries.GetEmployeeListCollection;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeesForm.Commands.AddEmployeesToFormFromCollections
{
    public record AddEmployeesToFormFromCollectionsCommand(EmployeeFormParam param) : ICommand;

    public class AddEmployeesToFormFromCollectionsCommandHandler : ICommandHandler<AddEmployeesToFormFromCollectionsCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeesToFormFromCollectionsCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddEmployeesToFormFromCollectionsCommand request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeListCollectionQuerySpecification(request.param.CollectionId);
            var employeesInCollection = await _uow.EmployeeCollectionsRepository.GetAllBySpecAsync(spec);
            int maxId = _uow.EmployeeFormRepository.GetMaxOrderInFile(request.param.FormId) + 1;

            foreach (var employeeInCollection in employeesInCollection.Data)
            {
                await _uow.EmployeeFormRepository.AddItem(new Domain.Models.EmployeeForm()
                {

                    EmployeeId = employeeInCollection.EmployeeId,
                    FormId = request.param.FormId,
                    EmployeeOrderNumber = maxId++
                });

            }
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }

}
