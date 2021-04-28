using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccessLayer
{
    public abstract class BaseCsvDAL<T>
        //where T:new()
    {

        public List<T> Read(string file)
        {
            var entities = new List<T> { };
            using (var reader = new StreamReader(@file))
            {
                //var x = new T();
                while (!reader.EndOfStream)
                {
                    var stream = reader.ReadLine();
                    var line = stream.Split('!');
                    var entity = ToEntity(line);
                    entities.Add(entity);
                }
            }
            return entities;
        }
        public abstract T ToEntity(string[] line);

    }
}
