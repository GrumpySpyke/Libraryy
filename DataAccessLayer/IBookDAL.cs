using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataBase;

namespace DataAccessLayer
{
    public interface IBookDAL
    {
        public Book SearchBookByName(string bookName);
        public List<Book> GetBooks();
        public void InsertBook (Book book);
    }
}
