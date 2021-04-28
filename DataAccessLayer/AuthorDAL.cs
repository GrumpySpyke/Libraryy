using System;
using System.Collections.Generic;
using System.Text;
using DataBase;
using System.Data.SqlClient;
using System.Windows;
using System.Data;

namespace DataAccessLayer
{
    public class AuthorDAL : DAL , IAuthorDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns></returns>
        public Author SearchAuthorByName(string authorName)
        {
            authorName = authorName.Replace("'", "''");
            var numberOfItems = 0;
            var author = new Author();
            var command = "Select * from [AuthorTable] au where au.AuthorName=@AuthorName";

           using (var connection = GetConnection())
           {
                var SQLcommand = new SqlCommand(command,connection);
                connection.Open();

                SQLcommand.Parameters.Add("@AuthorName", SqlDbType.VarChar, 50).Value = authorName;

                using (var dataReader = SQLcommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        
                        if (numberOfItems < 1)
                        {
                            numberOfItems++;
                            author.authorName = dataReader[0].ToString();
                            author.id = Int32.Parse(dataReader[1].ToString());
                        }
                        
                    }
                }
           }
            
            return author;
        }
        public List<Author> GetAuthors()
        {
            var list = new List<Author>();
            
            using var connection = GetConnection();
            var command= "select * from [AuthorTable]";
            using var SQLcommand= new SqlCommand(command, connection);
            SQLcommand.Connection.Open();
            using var dataReader = SQLcommand.ExecuteReader();
            while (dataReader.Read())
            {
                var author = new Author();
                author.authorName = dataReader[0].ToString();
                author.id = Int32.Parse(dataReader[1].ToString());
                list.Add(author);
               
            }
            foreach(var item in list)
            {
                Console.WriteLine(item.authorName);
            }
            SQLcommand.Connection.Close();
            return list;
            
        }
        public void InsertAuthor(Author author)
        {
            author.authorName = author.authorName.Replace("'", "''");
            using var connection = GetConnection() ;
            var command= "Insert into [AuthorTable](AuthorName) values(@AuthorName)";
            using var SQLcommand = new SqlCommand(command, connection);
            SQLcommand.Connection.Open();
            SQLcommand.Parameters.Add("@AuthorName", SqlDbType.VarChar, 50).Value = author.authorName;
            try
            {
            SQLcommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                
                
            }
            SQLcommand.Connection.Close();

        }
    }
}
