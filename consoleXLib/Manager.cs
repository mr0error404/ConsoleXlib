using System;

namespace consoleXLib
{
    public class Manager
    {
        // Properties //
        public int ManagerId { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        // Constructor
        public Manager(int managerId, string username, int roleId, string password, string mobile, string email)
        {
            ManagerId = managerId;
            Username = username;
            RoleId = roleId;
            Password = password;
            Mobile = mobile;
            Email = email;
        }

        // Methods
        public void AddUser()
        {
            
        }

        public void EditUser()
        {
            
        }

        public void DeleteUser()
        {
            
        }

        public void SearchUser()
        {

        }

        public void SearchBook()
        {
            
        }

        public void SearchCategory()
        {
            
        }

        public void AddCategory()
        {
            
        }

        public void EditCategory()
        {

        }

        public void DeleteCategory()
        {

        }

        public void SearchSubCategory()
        {

        }

        public void AddSubCategory()
        {
            
        }

        public void EditSubCategory()
        {
            
        }

        public void DeleteSubCategory()
        {
            
        }

        public void UpdateBookStatus()
        {
            
        }
    }
}
