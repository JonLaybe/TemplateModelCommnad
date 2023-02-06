namespace ServerCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthCommand auth = new AuthCommand("Login", "log", "<log> login password");
            auth.Command.Handler();

            Console.WriteLine(auth.Login);
            Console.WriteLine(auth.Password);
            Console.WriteLine(auth.GetAnswer());
        }
    }
}