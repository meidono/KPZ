using task3;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(() => AuthManager.Instance.Authenticate());
        Thread thread2 = new Thread(() => AuthManager.Instance.Authenticate());

        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        thread2.Join();
    }
}