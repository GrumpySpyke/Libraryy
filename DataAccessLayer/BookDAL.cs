using System;
using System.Collections.Generic;
using System.Text;
using DataBase;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class BookDAL : DAL , IBookDAL
    {
        public Book SearchBookByName(string bookName)
        {
            bookName = bookName.Replace("'", "''");
            var book = new Book();
            using var connection = GetConnection();
            var command = "select * from [BookTable] bt where bt.BookName=@BookName";
            using var SQLcommand = new SqlCommand(command, connection);
            SQLcommand.Connection.Open();
            SQLcommand.Parameters.Add("@BookName", SqlDbType.VarChar, 50).Value = bookName;
            using (var dataReader=SQLcommand.ExecuteReader())
            while(dataReader.Read())
            {
                book.bookName = dataReader[0].ToString();
                book.id = Int32.Parse(dataReader[1].ToString());
                book.authorId = Int32.Parse(dataReader[2].ToString());
            }
            SQLcommand.Connection.Close();
            return book;
            
        }
        public List<Book> GetBooks()
        {
            var list = new List<Book>();
            
            var command = "select * from [BookTable]";
            using var connection = GetConnection();
            using var SQLcommand = new SqlCommand(command, connection);
            SQLcommand.Connection.Open();
            using var dataReader = SQLcommand.ExecuteReader();
            while (dataReader.Read())
            {
                var book = new Book();
                book.bookName = dataReader[0].ToString();
                book.id = Int32.Parse(dataReader[1].ToString());
                book.authorId = Int32.Parse(dataReader[2].ToString());

                list.Add(book);
            }
            SQLcommand.Connection.Close();
            return list;

        }
        public void InsertBook(Book book)
        {
            book.bookName = book.bookName.Replace("'", "''");
            using var connection = GetConnection();
            var command = "Insert into [BookTable](BookName,AuthorId) values(@BookName,@AuthorId)";
            using var SQLcommand = new SqlCommand(command, connection);
            SQLcommand.Parameters.Add("@BookName", SqlDbType.VarChar, 50).Value = book.bookName;
            SQLcommand.Parameters.Add("@AuthorId", SqlDbType.Int).Value = book.authorId;
            SQLcommand.Connection.Open();
            try
            {
                SQLcommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
            SQLcommand.Connection.Close();

        }
    }
}

