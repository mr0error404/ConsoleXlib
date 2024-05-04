using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace consoleXLib
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(60)]
        public string SubcategoryName { get; set; }

        public Role(int roleId, string subcategoryName)
        {
            RoleId = roleId;
            SubcategoryName = subcategoryName;
        }

        public void AssignRole() { }

        public void RevokeRole() { }

        public void EditRole() { }
    }
}

