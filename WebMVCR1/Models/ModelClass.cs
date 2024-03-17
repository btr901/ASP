namespace WebMVCR1.Models
{
    public class ModelClass
    {
        public static string ModelHello()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = "";
            if (hour >= 0 && hour < 6) Greeting = "Доброй ночи";
            else if (hour >= 6 && hour < 12) Greeting = "Доброе утро";
            else if (hour >= 12 && hour < 18) Greeting = "Добрый день";
            else Greeting = "Добрый вечер";
            return Greeting;
        }
    }

}
