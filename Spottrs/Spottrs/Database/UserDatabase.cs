using SQLite;

namespace Spottrs.Database
{
    public class UserDatabase
    {
        string databasePath;
        private SQLiteConnection connection;

        public UserDatabase(string databasePath)
        {
            this.databasePath = databasePath;
        }

        public void Init()
        {
            connection = new SQLiteConnection(databasePath);
            //connection.CreateTable<>();   cannot continue until class UserAccount is finished
        }
    }
}
