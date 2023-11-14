using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            //by the following line of code we will get the details if the supplied name is found in the list
             return DataSource().Where(x=>x.Title==title||x.Author==authorName).ToList();

            //by the following code we can get if the supplied name contains substring of the name
            //return DataSource().Where(x=>x.Title.Contains(title)&&x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="A1"},
                new BookModel(){Id=2,Title="Dot Net Core",Author="A1"},
                new BookModel(){Id=3,Title="C#",Author="A2"},
                new BookModel(){Id=4,Title="Java",Author="A3"},
                new BookModel(){Id=5,Title="Php",Author="A3"}
            };
        }
    }
}
