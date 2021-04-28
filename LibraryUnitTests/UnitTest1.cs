using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using DataBase;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using BusinessLogic;

namespace LibraryUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        class AuthorDALMock :IAuthorDAL
        {
            public List<Author> GetAuthors()
            {
                return new List<Author>
                {
                    new Author
                    {
                        id=1,
                        authorName="Gigi",
                    },
                    new Author
                    {
                        id=2,
                        authorName="Gicu",
                    },
                };
            }
            public int InsertAuthorCallCount {get; private set; }
            public void InsertAuthor(Author author)
            {
                this.InsertAuthorCallCount++;
            }

            public Author SearchAuthorByName(string authorName)
            {
                if (authorName == "Gigi")
                    return new Author();
                return null;
            }

            List<AuthorBook>TestDAL1Mock()
            {
                var authorBooks=new List<AuthorBook>();
                var authorBook=new AuthorBook();
                authorBook.authorName = "Autor1";
                authorBook.bookName = "Carte6";
                authorBooks.Add(authorBook);
                authorBook.authorName = "Autor1";
                authorBook.bookName = "Carte7";
                authorBooks.Add(authorBook);
                authorBook.authorName = "Autor2";
                authorBook.bookName = "Carte8";
                authorBooks.Add(authorBook);
                authorBook.authorName = "Autor2";
                authorBook.bookName = "Carte9";
                authorBooks.Add(authorBook);


                return authorBooks;

            }
        }
           
        
        public void InsertIntoDB(List<AuthorBook> items, IBookDAL bookDAL, IAuthorDAL authorDAL)
        {
            var book = new Book();
            var author = new Author();

            foreach (var item in items)
            {

                author.authorName = item.authorName;

                if (authorDAL.SearchAuthorByName(author.authorName) == null) ;
                {
                    book.bookName = item.bookName;
                    authorDAL.InsertAuthor(author);
                }

                book.authorId = authorDAL.SearchAuthorByName(author.authorName).id;
                bookDAL.InsertBook(book);

            }
        }
            [TestMethod]
        public void TestMethod1()
        {
            //todo:simulare existenta unui autor
            var BL = new ImportToDB();
            //BL.InsertAuthors
        }
    }
}
