using SQLite;
using Spottrs.Models;

namespace Spottrs.Database
{
    public class UserDatabase
    {
        string databasePath;
        private SQLiteConnection connection;

        //Constructor that sets the database file's path
        public UserDatabase(string databasePath)
        {
            this.databasePath = databasePath;
        }

        //Creates the database file at 'databasePath' if it doesn't already exist
        public void Init()
        {
            connection = new SQLiteConnection(databasePath);
            connection.CreateTable<UserAccount>();
        }

        public List<UserAccount> GetAllAccounts()
        {
            connection = new SQLiteConnection(databasePath);
            return connection.Table<UserAccount>().ToList();
        }

        public void Add(UserAccount account)
        {
            connection.Insert(account);
            return;
        }
    }
}
