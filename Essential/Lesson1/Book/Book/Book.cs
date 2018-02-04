using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        Title title;
        Content contetnt;
        Author author;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.contetnt = new Content();
        }

        public Book(string title)
        {
            InitializeBook();
            this.title.Field = title;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.contetnt.Show();
        }

        public string Author
        {
            set { this.author.Field = value; }
        }

        public string Content
        {
            set { this.contetnt.Field = value; }
        }
    }
}
