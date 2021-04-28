using System;
using System.Collections.Generic;
using System.Text;
using DataBase;

namespace DataAccessLayer
{
    public interface IAuthorDAL
    {
        public List<Author> GetAuthors();
        public void InsertAuthor(Author author);
        public Author SearchAuthorByName(string authorName);
    }
}
