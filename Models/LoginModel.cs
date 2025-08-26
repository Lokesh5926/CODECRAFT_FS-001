using System.ComponentModel.DataAnnotations;

namespace CODECRAFT_FS_01.Models
{
    public class LoginModel
    {
            [Key]
            public string username { get; set; }

            [Required]
            public string password { get; set; }
    }
}
