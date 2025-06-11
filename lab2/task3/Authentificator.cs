using System;

namespace task3
{
    public sealed class AuthManager
    {
        private static readonly Lazy<AuthManager> instance = 
            new Lazy<AuthManager>(() => new AuthManager());

        private AuthManager() { }

        public static AuthManager Instance => instance.Value;

        public void Authenticate()
        {
            Console.WriteLine("Автентифікація виконана. Хеш-код: " + GetHashCode());
        }
    }
}
