namespace ConsoleApp101;

public class SmsService : ILogger
{
    public void Log(string message)
    {
        // شبیه‌سازی ثبت لاگ پیامک
        Console.WriteLine($"SMS log: {message}");
    }

    public void Alert(string alert)
    {
        // شبیه‌سازی ارسال پیامک هشدار
        Console.WriteLine($"sending sms alert: {alert}");
    }
}
