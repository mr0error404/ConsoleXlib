using System;

namespace consoleXLib
{
    public class Laibrarian
    {
        // Properties //
        public string UserName { get; set; }
        public int LaibrarianId { get; set; }
        public int Roled { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        // Constructor
        public Laibrarian(string userName, int laibrarianId, int roled, string password, string email, string mobile)
        {
            UserName = userName;
            LaibrarianId = laibrarianId;
            Roled = roled;
            Password = password;
            Email = email;
            Mobile = mobile;
        }

        // Methods
        public void Login()
        {

        }

        public void AddBook()
        {
            
        }

        public void DeleteBook()
        {
            
        }

        public void UpdateBook()
        {
            
        }

        public void FindBook()
        {
            
        }
    }
}
