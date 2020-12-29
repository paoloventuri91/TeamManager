using System;
using LiteDB;

namespace Repository    
{
    public class RepositoryManager: IDisposable
    {
        #region Fields

        private readonly LiteDatabase _database;

        #endregion

        public RepositoryManager()
        {
            _database = new LiteDatabase(@"Filename=database.db;Password='1234';connection=shared");
        }

        public T Insert<T>(T insertObj)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            
            collection.Insert(insertObj);

            return insertObj;
        }

        public T FindById<T>(Int32 id)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);

            return collection.FindById(id);
        }

        public T Update<T>(T updateObj)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);

            collection.Update(updateObj);

            return updateObj;
        }

        public void Dispose()
        {
            _database?.Dispose();
        }
    }
}
