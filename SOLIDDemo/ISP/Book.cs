﻿namespace SOLIDDemo.ISP;

public class Book : IBorrowable
{
    public string LibraryId { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public int Pages { get; set; }

    public int CheckOutDurationInDays { get; set; } = 0;

    public string Borrower { get; set; }

    public DateTime BorrowDate { get; set; }

    public void CheckOut(string borrower)
    {
        Borrower = borrower;
        BorrowDate = DateTime.Now;
    }

    public void CheckIn()
    {
        Borrower = "";
    }

    public DateTime GetDueDate()
    {
        return BorrowDate.AddDays(CheckOutDurationInDays);
    }
}


