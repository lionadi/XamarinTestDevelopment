using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using SharedCodePortableLibrary;

namespace BookStoreAndroid
{
    public class BooksAdapter : BaseAdapter
    {
        public List<Book> books;

        Activity activity;

        public BooksAdapter(Activity activity)
        {
            this.activity = activity;
        }

        public override int Count
        {
            get
            {
                return this.books.Count;
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(BookStoreAndroid.Resource.Layout.BookCell, parent, false);
            var nameLabel = view.FindViewById<TextView>(BookStoreAndroid.Resource.Id.nameTextView);
            var authorLabel = view.FindViewById<TextView>(BookStoreAndroid.Resource.Id.authorTextView);
            var publisherLabel = view.FindViewById<TextView>(BookStoreAndroid.Resource.Id.publisherTextView);
            var yearLabel = view.FindViewById<TextView>(BookStoreAndroid.Resource.Id.yearTextView);

            var data = this.books[position];

            nameLabel.Text = data.Name;
            authorLabel.Text = data.Author;
            publisherLabel.Text = data.Editor;
            yearLabel.Text = data.Year.ToString();

            return view;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return this.books[position].ID;
        }
    }
}