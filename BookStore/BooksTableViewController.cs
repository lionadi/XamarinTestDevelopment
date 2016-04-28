using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    public class Book
    {
        public String Name { get; set; }
        public String Author { get; set; }

        public String Editor { get; set; }

        public int Year { get; set; }
    }
	partial class BooksTableViewController : UITableViewController
	{
            List<Book> bookList;
        public BooksTableViewController(IntPtr handle) : base(handle)
        {
            this.bookList = new List<Book>();

            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 1", Editor = "Editor 1", Year = 2001 });
            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 2", Editor = "Editor 1", Year = 2001 });
            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 3", Editor = "Editor 1", Year = 2001 });
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            //return base.NumberOfSections(tableView);
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //return base.RowsInSection(tableView, section);
            return bookList.Count;
        }

        // Returns a reusable cell, change it values and returns it to be added to the table view
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;
            var dataInTheCell = this.bookList[indexPath.Row];
            cell.BookData = dataInTheCell;
            return cell;
            //return base.GetCell(tableView, indexPath);

        }

    }
}
