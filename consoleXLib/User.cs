using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using consoleXLib;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string UserEmail { get; set; }

    [Required]
    [Phone]
    public string Phone { get; set; }

    [ForeignKey("Role")]
    public int RoleId { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 6)]
    public string Password { get; set; }

    public List<string> BorrowedBooks { get; set; }

    public int NumberOfBorrowedBooks { get; set; }

    [Required]
    public DateTime LastActivityDate { get; set; }

    public virtual Role Role { get; set; }

    public User(int userId, string name, string username, string userEmail, string phone, int roleId, string password, List<string> borrowedBooks, int numberOfBorrowedBooks, DateTime lastActivityDate)
    {
        UserId = userId;
        Name = name;
        Username = username;
        UserEmail = userEmail;
        Phone = phone;
        RoleId = roleId;
        Password = password;
        BorrowedBooks = borrowedBooks;
        NumberOfBorrowedBooks = numberOfBorrowedBooks;
        LastActivityDate = lastActivityDate;
    }

    public void Login() { }

    public void EditUser() { }

    public void DeleteUser() { }

    public void SearchBook() { }

    public void ReserveBook() { }

    public List<string> GetBorrowedBooks()
    {
        return BorrowedBooks;
    }

    public int GetNumberOfBorrowedBooks()
    {
        return NumberOfBorrowedBooks;
    }

    public DateTime GetLastActivityDate()
    {
        return LastActivityDate;
    }
}