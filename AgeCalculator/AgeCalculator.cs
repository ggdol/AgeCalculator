namespace AgeCalculatorKata
{
    public class AgeCalculator
    {
        public int GetAge(DateTime birthDate, DateTime targetDate)
        {

            var age = targetDate.Year - birthDate.Year;

            if (HasHadBirthdayThisYear(birthDate, targetDate)) return age;

            return age-1;
        }

        private static bool HasHadBirthdayThisYear(DateTime birthDate, DateTime targetDate) {

            return (targetDate.Month > birthDate.Month)
                || birthDate.Month == targetDate.Month && targetDate.Day >= birthDate.Day;

        }

    }
} 