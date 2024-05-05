using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace consoleXLib
{
    public class SubCategory
    {
        // Properties
        [Key]
        public int SubcategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string ?SubcategoryName { get; set; }

        // Foreign Key
        [ForeignKey("MainCategory")]
        public int MainCategoryId { get; set; }
        public MainCategory ?MainCategory { get; set; }

        // Methods
        public void AddSubCategory()
        {

        }

        public void EditSubCategory()
        {

        }

        public void DeleteSubCategory()
        {

        }

        public void ViewSubCategories()
        {

        }
    }
}
