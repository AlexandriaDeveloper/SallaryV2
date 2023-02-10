using Domain.Shared;

namespace Domain.Constants;

public static class Constant
{
    public static class Model
    {
        public static class OrderConstants
        {

            public static string ABSENCE = "غياب بدون إذن";
            public static string PUNISHMENT_ABSENCE = "امر عقاب جزاء عن الغياب بدون إذن";
            public static string VACATION_WITHOT_SALLARY = "أجازة بدون مرتب";
            public static string PUNISHMENT_EXAMINATION_REWARD = "أمر عقاب خصم من مكافأة الامتحانات";
            public static string REPAY = "أمر أستراداد مبلغ";
            //  public static string DEDUCTION = "أستقطاع مبلغ من المرتب ";
            public static string FIXED_AMOUNT = "أستقطاع مبلغ ثابت";
            public static string SUBSCRIPTIONS = "أشتراكات";
        }

        public static class BudgetItems
        {
            public static string WAZIFI = "اجر وظيفى ";
            public static string MOKAMEL = "اجر مكمل";
            public static string TA3WIDI = "أجر تعويضى";
            public static string GAZAA = "جزاء";
            public static string ABSENCE = "غياب";
            public static string DEDUCTION = "أستقطاع مبلغ من المرتب ";
            public static string REPAY = "رد مبلغ";

            public static string SUBSCRIPTIONS = "أشتراكات";

        }
    }

    public static class ResultMessages
    {

        public static class SuccessMessages
        {
            public static string SAVED_SUCCESSFULLY = "تم الحفظ بنجاح";
        }
        public static class ErrorMessages
        {
            public static Error FAIL_WHILE_SAVING_DATA = new Error("", "خطأ اثناء الحفظ");
            public static Error ENTITY_NOT_EXIST = new Error("Not Found", "العنصر المطلوب غير موجود");
            public static Error ENTITY_DUBLICATION_EXCEPTION = new Error("Dublication", "لا يمكن تسجيل العنصر حيث انة موجود بالفعل");
            public static Error ENTITY_AlREDY_EXIST = new Error("Item Exist", "هذا العنصر موجود بالفعل ");

        }
        public class CommonMessages
        {
            private readonly int _messageCode;
            private readonly string? _message;

            public CommonMessages(int messageCode, string? message = null)
            {
                _messageCode = messageCode;
                _message = message;
            }
        }

    }
}
