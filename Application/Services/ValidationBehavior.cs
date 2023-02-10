using Domain.Shared;
using FluentValidation;

using MediatR;

namespace Domain.Services
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : Result
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators) => _validators = validators;





        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {

            if (!_validators.Any())
            {
                return await next();
            }

            //var context = new ValidationContext<TRequest>(request);
            Error[] failures = _validators
                .Select(x => x.Validate(request))
                .SelectMany(ValidationResult => ValidationResult.Errors)
                .Where(x => x is not null)
                .Select(failure => new Error(failure.PropertyName, failure.ErrorMessage))
                .Distinct()
                .ToArray();

            if (failures.Any())
            {


                return await Task.FromResult(CreateValidationResponse<TResponse>(failures));
            }

            return await next();
        }

        private static TResponse CreateValidationResponse<TResponse>(Error[] errors) where TResponse : Result
        {

            if (typeof(TResponse) == typeof(Result))
            {
                return (ValidationResult.WithErrors(errors) as TResponse)!;
            }

            object validationResult = typeof(ValidationResult<>)
                .GetGenericTypeDefinition()
                .MakeGenericType(typeof(TResponse).GenericTypeArguments[0])
                .GetMethod(nameof(ValidationResult.WithErrors))!
                .Invoke(null, new object?[] { errors })!;

            return (TResponse)validationResult;
        }



    }

}
