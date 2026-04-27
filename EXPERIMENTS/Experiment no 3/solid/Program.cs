
// solid principles in c #
/*
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.RegisterUser();
        }
    }

    // SRP: Handles only user registration
    class UserService
    {
        public void RegisterUser()
        {
            Console.WriteLine("User registered");

            UserRepository repository = new UserRepository();
            repository.Save();
        }
    }

    // SRP: Handles only saving data
    class UserRepository
    {
        public void Save()
        {
            Console.WriteLine("User saved to database");
        }
    }
}
*/


using System;

class Program
{
    static void Main()
    {
        ISave save = new DatabaseSave(); // can change to FileSave
        save.Save();
    }
}

// OCP: interface (no change needed later)
interface ISave
{
    void Save();
}

// first implementation
class DatabaseSave : ISave
{
    public void Save()
    {
        Console.WriteLine("Saved to database");
    }
}

// new feature added without changing old code
class FileSave : ISave
{
    public void Save()
    {
        Console.WriteLine("Saved to file");
    }
}
