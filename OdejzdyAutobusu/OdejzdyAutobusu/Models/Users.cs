using System.ComponentModel.DataAnnotations;

namespace OdejzdyAutobusu.Models
{
    public class Users
    {
        [Key] [Required]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }
        [Required, DataType(DataType.Password)]
        public string pwd { get; set; }
    }
}