using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ZODIAKS.Models;
using System.Threading.Tasks;

namespace ZODIAKS.Data
{
    public class ZodiaksDB
    {
        readonly SQLiteAsyncConnection db;

        public ZodiaksDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Zodiak>().Wait();
        }

        public Task<List<Zodiak>> GetZodiaksAsync()
        {
            return db.Table<Zodiak>().ToListAsync();
        }

        public Task<Zodiak> GetZodiakAsync(int id)
        {
            return db.Table<Zodiak>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveZodiakAsync(Zodiak zodiak)
        {
            if (zodiak.ID != 0)
                return db.UpdateAsync(zodiak);
            else
                return db.InsertAsync(zodiak);
        }

        public Task<int> DeleteZodiakAsync(Zodiak zodiak)
        {
            return db.DeleteAsync(zodiak);
        }


    }
}
