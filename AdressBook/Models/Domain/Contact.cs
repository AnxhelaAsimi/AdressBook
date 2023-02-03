namespace AdressBook.Models.Domain
{
    public class Contact
    {
        public Contact()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string OfficeNumber { get; set; }
        public string Address { get; set; }

        public Contact(AddContactViewModel newContact)
        {
            this.Id = new Guid();
            this.Name = newContact.Name;
            this.Surname = newContact.Surname;
            this.Company = newContact.Company;
            this.Email = newContact.Email;
            this.PhoneNumber1 = newContact.PhoneNumber1;
            this.PhoneNumber2 = newContact.PhoneNumber2;
            this.OfficeNumber= newContact.OfficeNumber;
            this.Address = newContact.Address;
        }


    }

}
