using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleXLib
{
    public class Laibrarian
    {
        public string UserName { get; set; }
        public int Laibrarianid { get; set; }
        public int Roled { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Laibrarian(string UserName, int ID, int Roled, string Password, string Emaile, string Mobile)
        {
            this.UserName = UserName;
            this.Laibrarianid = Laibrarianid;
            this.Roled = Roled;
            this.Password = Password;
            this.Email = Emaile;
            this.Mobile = Mobile;
        }
        public void Login()
        {
            /////////test  
        }
        public void AddBook( )
        {
            ///////////C#
        }
        public void DeleteBook()
        {
            ////////C++
        }
        public void UpdateBook()
        {
            /////////Java
        }
        public void FindBook()
        {
            /////
        }
    }
}
