using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AbdullinaPZ18.Models
{
    public class User
    {
        [JsonPropertyName("user_id")]
        [Key]
        public int UserId { get; private set; }


        [JsonPropertyName("user_name")]
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }


        [JsonPropertyName("phone")]
        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }


        [JsonPropertyName("login")]
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }


        [JsonPropertyName("password")]
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }


        [JsonPropertyName("user_type_id")]
        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }


        public bool IsPhoneValid()
        {
            return Phone.Length == 10 && Phone.All(char.IsDigit);
        }
    }
}
