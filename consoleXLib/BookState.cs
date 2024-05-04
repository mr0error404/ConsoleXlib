using System;

namespace consoleXLib
{
    public class BookState
    {
        // Properties // //
        public int StatusId { get; set; }
        public string StatusName { get; set; }
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
            // Implement your logic for creating status here
        }

        public void UpdateStatus()
        {
            // Implement your logic for updating status here
        }
    }
}

