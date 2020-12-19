using ContactKeeper.Domain.Enums;

namespace ContactKeeper.Domain.Entities
{
    public class Contact : Entity
    {
        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Type = ETypeContact.Personal;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public ETypeContact Type { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
        }
        public void UpdateEmail(string email)
        {
            Email = email;
        }
        public void UpdateContactType(ETypeContact type)
        {
            Type = type;
        }
    }
}