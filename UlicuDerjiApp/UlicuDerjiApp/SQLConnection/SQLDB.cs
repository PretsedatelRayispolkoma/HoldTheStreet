using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using UlicuDerjiApp.Models;

namespace UlicuDerjiApp.SQLConnection
{
    public class SQLDB
    {
        readonly SQLiteConnection db;
        public SQLDB(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<User>();
            db.CreateTable<Street>();
            db.CreateTable<Shodnyak>();
            db.CreateTable<Strela>();
        }

        public IEnumerable<User> GetUsers()
        {
            return db.Table<User>().ToList();
        }

        public User GetUser(int id)
        {
            return db.Get<User>(id);
        }

        public int DeleteUser(int id)
        {
            return db.Delete<User>(id);
        }

        public int SaveUser(User item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }

        public IEnumerable<Street> GetStreets()
        {
            return db.Table<Street>().ToList();
        }

        public Street GetStreet(int id)
        {
            return db.Get<Street>(id);
        }

        public int DeleteStreet(int id)
        {
            return db.Delete<Street>(id);
        }

        public Street GetStreetWhere(int id)
        {
            return db.Table<Street>().Where(s => s.Id == id).FirstOrDefault();
        }

        public int SaveStreet(Street item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }

        public IEnumerable<Shodnyak> GetShodnyaks()
        {
            return db.Table<Shodnyak>().ToList();
        }

        public Shodnyak GetShodnyak(int id)
        {
            return db.Get<Shodnyak>(id);
        }

        public int DeleteShodnyak(int id)
        {
            return db.Delete<Shodnyak>(id);
        }

        public int SaveShodnyak(Shodnyak item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }

        public IEnumerable<Strela> GetStrelas()
        {
            return db.Table<Strela>().ToList();
        }

        public Strela GetStrela(int id)
        {
            return db.Get<Strela>(id);
        }

        public int DeleteStrela(int id)
        {
            return db.Delete<Strela>(id);
        }

        public int SaveStrela(Strela item)
        {
            if (item.Id != 0)
            {
                db.Update(item);
                return item.Id;
            }
            else
            {
                return db.Insert(item);
            }
        }
    }
}
