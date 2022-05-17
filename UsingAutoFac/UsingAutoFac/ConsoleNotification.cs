// See https://aka.ms/new-console-template for more information


public class ConsoleNotification : INotificationService
{
    public ConsoleNotification()
    {
    }

    public void NotifyChanged(User user)
    {
        Console.WriteLine($"O novo nome é {user.UserName}");
    }
}