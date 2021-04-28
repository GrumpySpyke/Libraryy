using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL
    {
        private const string _connection_String = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Library;Integrated Security=True;Pooling=False";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connection_String);
        }
        //todo:citit con string din app.config
    }
}
