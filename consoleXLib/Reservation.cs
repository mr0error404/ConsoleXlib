using System;
namespace consoleXLib
{
	public class Reservation
	{

        // Properties
        private int reservationId;
        private int userId;
        private int bookId;
        private DateTime reservedDate;
        private DateTime returnDate;
        private int statusId;

        // Constructor
        public Reservation(int reservationId, int userId, int bookId, DateTime reservedDate, DateTime returnDate, int statusId)
        {
            this.reservationId = reservationId;
            this.userId = userId;
            this.bookId = bookId;
            this.reservedDate = reservedDate;
            this.returnDate = returnDate;
            this.statusId = statusId;
        }

        // Methods
        public void MakeReservation()
        {
            
        }

        public void UpdateReturnDate(DateTime newReturnDate)
        {
            
        }
    }
}

