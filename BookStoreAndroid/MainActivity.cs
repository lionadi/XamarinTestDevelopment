using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using SharedCodePortableLibrary;

namespace BookStoreAndroid
{
    [Activity(Label = "BookStoreAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        List<Book> bookList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            this.bookList = new List<Book>();
            
            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 1", Editor = "Editor 1", Year = 2001 });
            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 2", Editor = "Editor 1", Year = 2001 });
            this.bookList.Add(new Book() { Author = "Author 1", Name = "Book 3", Editor = "Editor 1", Year = 2001 });

            var listAdapter = new BooksAdapter(this);
            listAdapter.books = this.bookList;

            this.ListAdapter = listAdapter;
        }
    }

    //public class Book
    //{
    //    public int ID { get; set; }
    //    public String Name { get; set; }
    //    public String Author { get; set; }

    //    public String Editor { get; set; }

    //    public int Year { get; set; }

    //    public override string ToString()
    //    {
    //        return String.Format("{0} - {1} - {2} - {3}", this.Name, this.Author, this.Editor, this.Year);
    //    }
    //}
}

