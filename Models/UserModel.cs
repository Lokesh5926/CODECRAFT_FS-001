using System.ComponentModel.DataAnnotations;

namespace CODECRAFT_FS_01.Models
{
    public class UserModel
    {
        [Key]  // Primary Key
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [Required, EmailAddress]
        public string email { get; set; }

        [Required]
        public string phno { get; set; }
    }
}