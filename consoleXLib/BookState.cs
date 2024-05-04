using System;
using System.ComponentModel.DataAnnotations;

namespace consoleXLib
{
    public class BookState
    {
        // Properties
        [Key]
        public int StatusId { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusName { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        // Constructor
        public BookState(int statusId, string statusName, DateTime createDate)
        {
            StatusId = statusId;
            StatusName = statusName;
            CreateDate = createDate;
        }

        // Methods
        public void CreateStatus()
        {

        }

        public void UpdateStatus()
        {

        }
    }
}
