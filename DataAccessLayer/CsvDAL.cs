using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataBase;
namespace DataAccessLayer
{
    public class CsvDAL:BaseCsvDAL<AuthorBook>
    {

        public override AuthorBook ToEntity(string[] line)
        {
            return new AuthorBook
            {
                authorName = line[0],
                bookName = line[1],
            };
        }
    }
}
