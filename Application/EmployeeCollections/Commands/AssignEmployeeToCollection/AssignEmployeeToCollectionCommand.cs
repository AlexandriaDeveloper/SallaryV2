using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeCollections.Commands.AssignEmployeeToCollection
{
    public record AssignEmployeeToCollectionCommand(EmployeeCollectionToAddDto employeeCollection) : ICommand;
    public class AssignEmployeeToCollectionCommandHandler : ICommandHandler<AssignEmployeeToCollectionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AssignEmployeeToCollectionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AssignEmployeeToCollectionCommand request, CancellationToken cancellationToken)
        {

            var maxOrder = _uow.EmployeeCollectionsRepository.MaxOrderByCollectionId(request.employeeCollection.CollectionId);



            var employeeCollectionToDb = _mapper.Map<EmployeeCollection>(request.employeeCollection);
            employeeCollectionToDb.EmployeeOrderInCollection = maxOrder + 1;
            await _uow.EmployeeCollectionsRepository.AddItem(employeeCollectionToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }
    public class AssignEmployeeToCollectionCommandValidator : AbstractValidator<AssignEmployeeToCollectionCommand>
    {
        public AssignEmployeeToCollectionCommandValidator()
        {
            RuleFor(x => x.employeeCollection.EmployeeId).NotEmpty();
            RuleFor(x => x.employeeCollection.CollectionId).NotEmpty();
        }
    }

    public class AssignEmployeeToCollectionCommandSpecification : Specification<EmployeeCollection>
    {
        public AssignEmployeeToCollectionCommandSpecification(int collectionId)
        {
            AddCriteries(x => x.CollectionId == collectionId);

        }

    }

    public class EmployeeCollectionToAddDto
    {
        public int CollectionId { get; set; }
        public int EmployeeId { get; set; }
        public int? EmployeeOrderInCollection { get; set; }
    }
}
