namespace PhoneBook;

public class ContactManager
{
    private readonly List<Contact> _contacts = [];
    private int _nextId = 1;
    
    public void AddContact(string name, string phoneNumber)
    {
        var contact = new Contact(_nextId, name, phoneNumber);
        _contacts.Add(contact);
        _nextId++;
    } 

    public void RemoveContact(int id)
    {
        var contact = _contacts.FirstOrDefault(x => x.Id == id);
        if (contact != null)
        {
            _contacts.Remove(contact);
        }
    }
    
    public List<Contact> GetAllContacts()
    {
        return _contacts;
    }
}