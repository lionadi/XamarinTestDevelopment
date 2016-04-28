using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
	partial class BookTableViewCell : UITableViewCell
	{
        private Book bookdata;
        public Book BookData
        {
            get
            {
                return this.bookdata;
            }

            set
            {
                this.bookdata = value;
                bookAuthorLabel.Text = bookdata.Author;
                bookNameLabel.Text = this.bookdata.Name;
                bookPublisherLabel.Text = this.bookdata.Editor;
                bookYearLabel.Text = this.bookdata.Year.ToString();
            }
        }
		public BookTableViewCell (IntPtr handle) : base (handle)
		{

		}
	}
}
