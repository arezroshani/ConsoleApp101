namespace ConsoleApp101;

public class EmailService : ILogger
{
    private readonly string email;
    private readonly string password;

    public EmailService(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public void Log(string message)
    {
        // فرضاً فقط نمایش پیام در Console
        Console.WriteLine($"Email Log: {message}");
    }

    public void Alert(string alert)
    {
        // ارسال ایمیل هشدار (شبیه‌سازی)
        Console.WriteLine($"sending alrt email : {alert}");
    }
}
