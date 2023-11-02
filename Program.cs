namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Leman");
            user.Id = 2;
            user.Name = "Ugur";
            Console.WriteLine("User Information:");
            Console.WriteLine("ID: " + user.Id);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + User.Age);


            User.ChangeAge(30);


            Console.WriteLine("Yasi deyisdikden sonra istifadeci melumatlari");
            Console.WriteLine("ID: " + user.Id);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Age: " + User.Age);
        }
    }
}