using System;
using System.Collections.Generic;

namespace addressbook {
    public class Contact {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
    public class AddressBook {
        public Dictionary<string, Contact> ADBOOK { get; set; } = new Dictionary<string, Contact> ();

        public void AddContact (Contact name) {
            try {
                ADBOOK.Add (name.Email, name);
                Console.WriteLine ($"Contact Name: {name.FirstName}");
            } catch {
                Console.WriteLine ($"Contact {name.FirstName} already exists!");
            }
        }
        public Contact GetByEmail (string email) {
            return ADBOOK[email];
        }
    }

}