
using Domain.Enums;

namespace Domain.Shared
{


    public class Result
    {

        protected internal Result(bool isSuccess, Error error)
        {

            if (isSuccess && error != Error.None)
            {
                throw new InvalidOperationException();
            }
            if (!isSuccess && error == Error.None)
            {
                throw new InvalidOperationException();
            }

            IsSuccess = isSuccess;
            Error = error;
        }
        protected internal Result(bool isSuccess, SaveState saveState)
        {
            if (!isSuccess && saveState == SaveState.SqlDublicateException)
            {
                Error = Constants.Constant.ResultMessages.ErrorMessages.ENTITY_DUBLICATION_EXCEPTION;
            }
            if (!isSuccess && saveState == SaveState.SqlException)
            {
                Error = Constants.Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA;
            }
            if (!isSuccess && saveState == SaveState.Exception)
            {
                Error = Constants.Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA;
            }

            IsSuccess = isSuccess;
            //Error = error;
        }

        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

        public Error Error { get; }

        public static Result Success() => new(true, Error.None);
        public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);

        public static Result Failure(SaveState saveState) => new(false, saveState);
        public static Result Failure(Error error) => new(false, error);
        public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);



        public static Result<TValue> Create<TValue>(TValue value) =>
            value is not null ? Success(value) : Failure<TValue>(Error.NullValue);



    }
}
