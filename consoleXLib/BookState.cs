using System;
namespace consoleXLib
{
	public class BookState
	{
		// Properties
    private int statusId;
    private string statusName;
    private DateTime createDate;

    // Constructor
    public BookState(int statusId, string statusName, DateTime createDate)
    {
        this.statusId = statusId;
        this.statusName = statusName;
        this.createDate = createDate;
    }

    // Methods
    public void CreateStatus(){}

    public void UpdateStatus(){}
	}
}

