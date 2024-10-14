namespace lr3.Services
{
    public class TimeService
    {
        public string GetTimeOfDayMessage()
        {
            var currentTime = DateTime.Now.TimeOfDay;

            if (currentTime.Hours >= 6 && currentTime.Hours < 12)
            {
                return "Зараз ранок";
            }
            else if (currentTime.Hours >= 12 && currentTime.Hours < 18)
            {
                return "Зараз день";
            }
            else if (currentTime.Hours >= 18 && currentTime.Hours < 24)
            {
                return "Зараз вечір";
            }
            else
            {
                return "Зараз ніч";
            }
        }
    }
}
