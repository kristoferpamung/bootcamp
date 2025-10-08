using Serilog;
using Serilog.Formatting.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(new JsonFormatter())
            .WriteTo.File(new JsonFormatter(),"log/myapp.json", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Debug("Hello ini Text dari Serilog Debug > digunakan untuk debuging");
        Log.Information("Hello ini Text dari Serilog Information > Digunakan untuk informasi, aplikasi berjalan normal");
        Log.Warning("Hello ini text dari Serilog Warning > Digunakan untuk menampilkan warning ketika tidak error tapi kemungkinan akan menyebabkan error");
        Log.Error("Hello ini text dari Serilog Error > digunakan ketika terjadi error, Aplikasi masih berjalan");
        Log.Fatal("Hello ini text dari Serilog Fatal > aplikasi dapat berhenti");
    }

}