using Domain.Shared;

namespace Domain.Exceptions
{
    /// <summary>
    /// TODO LATER
    /// </summary>

    public class DublicationException : Exception
    {

        public DublicationException(int code) : base()
        {

            GetMessage(code);
        }


        private Result? GetMessage(int code)
        {
            Result? result = null;
            switch (code)
            {
                case 2601:
                    result = Result.Failure(new Error(code.ToString(), "لا يمكن تسجيل ال عنصر حيث انة مسجل بالفعل "));
                    break;
                default:
                    break;
            }

            return result;
        }


    }
}
