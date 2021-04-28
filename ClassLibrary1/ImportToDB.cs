using System;
using System.Collections.Generic;
using System.IO;
using DataAccessLayer;
using DataBase;

namespace BusinessLogic
{
    public class ImportToDB
    {
        //InsertIntoDB(Ibook,IAuthor,ICSV)
        public void InsertIntoDB(List<AuthorBook> items,IBookDAL bookDAL, IAuthorDAL authorDAL)
        {
            var book=new Book();
            var author=new Author();
            
            foreach (var item in items)
            {
           
                author.authorName = item.authorName;
                book.bookName = item.bookName;
                if (authorDAL.SearchAuthorByName(author.authorName)==null);
                {
                    authorDAL.InsertAuthor(author);
                }

                book.authorId = authorDAL.SearchAuthorByName(author.authorName).id;
                bookDAL.InsertBook(book);

            }
            
        }

    }
}
