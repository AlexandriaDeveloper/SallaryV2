using Domain.Enums;

namespace Domain.Shared
{

    public class Result<TValue> : Result
    {
        private readonly TValue? _value;

        private readonly IPagination _pagination;

        protected internal Result(TValue? value, bool isSuccess, Error error) : base(isSuccess, error)
        {



            _value = value;

        }
        protected internal Result(bool isSuccess, SaveState error) : base(isSuccess, error)
        {

        }

        public TValue Value => IsSuccess
            ? _value! :
            throw new InvalidOperationException("The value of  a failure result can not be accessed. ");

        public static implicit operator Result<TValue>(TValue value) => Create(value);

        public static new Result<TValue?> Failure(Error error) => new(default(TValue), false, error);
        public static new Result<TValue?> Failure(SaveState saveState) => new(false, saveState);
    }
}
