namespace PhoneBook;

public class Contact
{
    public int Id { get; }
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            _name = value;
        } 
    }
    private string _phoneNumber;
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Phone number cannot be empty");
            _phoneNumber = value;
        } 
    }

    public Contact(int id, string name, string phoneNumber)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
    }
    
    public override string ToString()
    {
        return $"=== Contact ===\n" +
               $"ID: {Id}\n" +
               $"Имя: {Name}\n" +
               $"Телефон: {PhoneNumber}\n";
    }
}