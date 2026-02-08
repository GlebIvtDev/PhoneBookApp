namespace PhoneBook;

public class ConsoleInterface
{
    private readonly ContactManager _contactManager;

    public ConsoleInterface(ContactManager contactManager)
    {
        _contactManager = contactManager;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Phone Book Menu: ");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Show all contacts");
            Console.WriteLine("3. Remove contact");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter phone number: ");
                    var phoneNumber = Console.ReadLine();
                    _contactManager.AddContact(name, phoneNumber);
                    Console.WriteLine("Contact added");
                    break;
                case "2":
                    var contacts = _contactManager.GetAllContacts();
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine(contact);
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter ID of the contact to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        _contactManager.RemoveContact(id);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}