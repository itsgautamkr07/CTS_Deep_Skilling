using System;

interface INotification
{
    void Notify();
}

class EmailNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("Email Notification Sent");
    }
}

class SMSNotification : INotification
{
    public void Notify()
    {
        Console.WriteLine("SMS Notification Sent");
    }
}

abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
}

class EmailFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}

class SMSFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SMSNotification();
    }
}

class Program
{
    static void Main()
    {
        NotificationFactory factory = new EmailFactory();
        INotification notification = factory.CreateNotification();
        notification.Notify();

        factory = new SMSFactory();
        notification = factory.CreateNotification();
        notification.Notify();
    }
}
