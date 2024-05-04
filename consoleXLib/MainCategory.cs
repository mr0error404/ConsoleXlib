using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace consoleXLib
{
    public class MainCategory
    {
        // Properties
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        // Methods
        public void AddMainCategory()
        {

        }

        public void EditMainCategory()
        {

        }

        public void DeleteMainCategory()
        {

        }

        public void ViewMainCategory()
        {

        }
    }
}
