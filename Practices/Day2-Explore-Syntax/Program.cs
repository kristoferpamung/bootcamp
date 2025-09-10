

string menu = """
====== Contact App ======
Menu :
1. Read Contact
2. Create Contact
3. Update Contact
4. Delete Contact
5. Exit 
""";

bool loop = true;
string? confirm;

Contact windah = new();
windah.Name = "Windah Basudara";
windah.Age = 30;
windah.Address = "Kebumen";
windah.PhoneNumber = "088123456789";

Contact[] contacts = new Contact[10];

Console.WriteLine(menu);

while (loop)
{
    Console.Write("Silahkan Masukkan (1-5) :");
    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Contact List :");
            for (int i = 0; i <= contacts.Length - 1; i++)
            {
                if (contacts[i] == null)
                {
                    Console.WriteLine($"{i + 1} - Kosong");
                }
                else
                {
                    Console.WriteLine($"{i + 1} - {contacts[i].Name} - {contacts[i].Age} - {contacts[i].Address} - {contacts[i].PhoneNumber}");
                }
            }
            Console.Write("Continue? (y/n) ");
            confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "y")
            {
                loop = true;
                Console.WriteLine(menu);
            }
            else
            {
                loop = false;
            }
            break;

        case "2":
            Console.Write("Enter name: ");
            string? name = Console.ReadLine();
            Console.Write("Enter age (number only): ");
            string? age = Console.ReadLine();
            Console.Write("Enter address: ");
            string? address = Console.ReadLine();
            Console.Write("Enter phone number(number only): ");
            string? phoneNumber = Console.ReadLine();

            if (name != null && age != null && address != null && phoneNumber != null)
            {
                Contact contact = new()
                {
                    Name = name,
                    Age = int.Parse(age),
                    Address = address,
                    PhoneNumber = phoneNumber
                };
                addContact(contact);
                Console.WriteLine("Success add new contact");
                Console.WriteLine(menu);
                break;
            }
            loop = false;
            break;
        case "3":
            Console.Write("index of contact (1-10): ");
            string? indexString = Console.ReadLine();
            if (indexString != null)
            {
                int index = int.Parse(indexString) - 1;
                if (index >= 10)
                {
                    Console.WriteLine("index out of Range!");
                    Console.WriteLine(menu);
                    break;
                }
                if (contacts[index] != null)
                {
                    Console.Write($"Update name of {contacts[index].Name}:  ");
                    string? updatedName = Console.ReadLine();
                    Console.Write($"Update age of {contacts[index].Age} (number only): ");
                    string? updatedAge = Console.ReadLine();
                    Console.Write($"Updated address of {contacts[index].Address}: ");
                    string? updatedAddress = Console.ReadLine();
                    Console.Write($"Updated phone number of {contacts[index].PhoneNumber} (number only): ");
                    string? updatedPhoneNumber = Console.ReadLine();

                    Contact updatedContact = new()
                    {
                        Name = updatedName ?? contacts[index].Name,
                        Age = int.Parse(updatedAge ?? contacts[index].Age.ToString()),
                        Address = updatedAddress ?? contacts[index].Address,
                        PhoneNumber = updatedPhoneNumber ?? contacts[index].PhoneNumber
                    };

                    updateContact(updatedContact, index);
                    Console.WriteLine($"Contact of index {indexString} successful updated!");
                    Console.WriteLine(menu);
                }
                else
                {
                    Console.WriteLine("You choice empty contact! please another index!");
                    Console.WriteLine(menu);
                }

            }
            
            break;
        case "4":
            Console.Write("index of contact (1-10): ");
            string? indexDeleteString = Console.ReadLine();
            if (indexDeleteString == "")
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(menu);
                break;
            }
            int indexDelete = int.Parse(indexDeleteString?? "11") - 1 ;
            if (indexDelete >= 10)
            {
                Console.WriteLine("index out of Range!");
                Console.WriteLine(menu);
                break;
            }        
            deleteContact(indexDelete);
            Console.WriteLine($"Contact of index {indexDeleteString} successful deleted!");
            Console.WriteLine(menu);
            break;
        case "5":
            Console.WriteLine("Bye-bye...");
            loop = false;
            break;
        default:
            Console.WriteLine("Invalid Input!");
            Console.WriteLine(menu);
            break;
    }
}

void addContact(Contact contact)
{
    for (int i = 0; i <= contacts.Length - 1; i++)
    {
        if (contacts[i] == null)
        {
            contacts[i] = contact;
            break;
        }
        else
        {
            Console.WriteLine("Contact Full!");
        }
    }
}
void updateContact(Contact contact, Index i)
{
    contacts[i] = contact;
}

void deleteContact(int index)
{
    contacts[index] = null!;
}

public class Contact
{
    private string _name = "";
    private int _age;
    private string _address = "";
    private string _phoneNumber = "";

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }
}