using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

namespace Spottrs.Models
{

    [System.ComponentModel.DataAnnotations.Schema.Table("UserAccount")] //Might be able to remove this later on
    class UserAccount //lots more needed in this to get this to function
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]  //if doesn't work, swap SQLite with System......Schema
        public int Id { get; set; }
        public string userName { get; set; }
        
    }
}
