using System.Globalization;

namespace PhoneBook;

class Program
{
    static void Main(string[] args)
    {
        var contactManager = new ContactManager();
        var consoleInterface = new ConsoleInterface(contactManager);
        consoleInterface.Run();
    }
}