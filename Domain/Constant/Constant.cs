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

        public static class Grades
        {
            public static string MOMTAZA = "الممتازة";
            public static string ALIA = "العاليه";
            public static string KABIR = "كبير";

            public static string AWLA = "الاولى";
            public static string AWLA_A = "الاولى-أ";
            public static string AWLA_B = "الاولى-ب";

            public static string TANIA = "الثانيه";
            public static string TANIA_A = "الثانيه-أ";
            public static string TANIA_B = "الثانيه-ب";

            public static string TALTA = "الثالثه";
            public static string TALTA_A = "الثالثه-أ";
            public static string TALTA_B = "الثالثه-ب";
            public static string TALTA_C = "الثالثه-ج";

            public static string RABA = "الرابعه";
            public static string RABA_A = "الرابعه-أ";
            public static string RABA_B = "الرابعه-ب";

            public static string KHAMSA = "الخامسه";
            public static string KHAMSA_A = "الخامسه-أ";
            public static string KHAMSA_B = "الخامسه-ب";

            public static string SADSA = "السادسه";
            public static string SADSA_A = "السادسه-أ";
            public static string SADSA_B = "السادسه-ب";
        }
    }


    public static class FinincialData
    {

        public static string WAZIFI = "اجر وظيفى ";
        public static string MOKAMEL = "اجر مكمل";
        public static string SHAMEL = "اجر الشامل";
        public static string TAWIDI = "حافز تعويضى";

        public static string TAWIDI_2016 = "حافز تعويضى 2016";
        public static string AGMALI_AGR = "اجمالى الاجر ";
        public static string BASIC = "الاساسى";
        public static string BASIC2 = "100% من الاساسى";
        public static string ALAWAT = "علاوات";
        public static string HAWAFEZ = "حوافز";
        public static string BADALAT = "بدلات";
        public static string BADAL_HAD_ADNA = "بدل حد ادنى";
        public static string BADAL_MKHATER = "بدل مخاطر";
        public static string BADAL_ADWA = "بدل عدوى";

        public static string ALAWA_2015 = "علاوة دوريه 2015";
        public static string ALAWA_2016 = "علاوة دوريه 2016";

        public static string ALAWA_2017 = "علاوة دوريه 2017";
        public static string ALAWA_2017_2 = "علاوة استثنائيه 2017";


        public static string ALAWA_2018 = "علاوة دوريه 2018";
        public static string ALAWA_2018_2 = "علاوة استثنائيه 2018";

        public static string ALAWA_2019 = "علاوة دوريه 2019";
        public static string ALAWA_2020 = "علاوة دوريه 2020";
        public static string ALAWA_2021 = "علاوة دوريه 2021";

        public static string ALAWA_2022 = "علاوة دوريه 2022";


        public static string BASIC_150 = "150% من الاساسى";
        public static string BASIC_50 = "50% من الاساسى";
        public static string BADAL_GAWDA = "بدل جودة";
        public static string ALAWA_DWARIA = "علاوة الحد الادنى";
        public static string ALAWA_KHIR_MADMOMA = "علاوات غير مضمومه";
        public static string ALAWA_IGTMAIA = "علاوة اجتماعيه";
        public static string ALAWA_IDAFIA = "علاوة اضافيه";
        public static string MENHA = "المنحة";
        public static string BADAL_ALAWA_IGTMAIA_WE_MENHA = "بدل علاوة اجتماعيه و منحة";

        public static string MOKAMEL_MOSTABAD = "مكمل مستبعد";
        public static string MOSTAHAK_HAD_ADNA = "مستحق حد ادنى";
        public static string HAFEZ_IDAFI = "حافز اضافى";


        public static string HAFEZ_2019 = "2019 حافز";
        public static string HAFEZ_2020 = "2020 حافز";
        public static string HAFEZ_2021 = "2021 حافز";
        public static string HAFEZ_2022 = "2022 حافز";
        public static string HAFEZ_2023 = "2023 حافز";
        public static string BADAL_GHALA_2022 = "بدل غلاء معيشه 2022 ";
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
