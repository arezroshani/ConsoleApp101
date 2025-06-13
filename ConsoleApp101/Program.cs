using ConsoleApp101;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var stock = new Stock("THPW");
var notificationManager = new NotificationManager();

string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
notificationManager.AddLogger(new FileService(fileName));
notificationManager.AddLogger(new EmailService("youremail@example.com", "password"));
notificationManager.AddLogger(new SmsService());

// Event handler with explicit parameter types
stock.PriceChanged += (object sender, PriceChangeEventArgs e) =>
{
    if (e.LastPrice != 0 && (e.NewPrice - e.LastPrice) / e.LastPrice > 0.1m)
    {
        notificationManager.Alert("Alert: Stock price increased by more than 10%!");
    }
};

Console.Write("Enter initial price: ");
decimal price = decimal.Parse(Console.ReadLine() ?? "0");
stock.Price = price;

Console.Write("Enter new price: ");
decimal newPrice = decimal.Parse(Console.ReadLine() ?? "0");
stock.Price = newPrice;

notificationManager.Log($"Old price: {price}");
notificationManager.Log($"New price: {newPrice}");
Console.WriteLine("Opening log file in Notepad...");
System.Diagnostics.Process.Start("notepad.exe", fileName);


Console.WriteLine($"Logs saved to file {fileName}.");
Console.WriteLine("Press Enter to open the log file...");
Console.ReadLine();

System.Diagnostics.Process.Start("notepad.exe", fileName);
