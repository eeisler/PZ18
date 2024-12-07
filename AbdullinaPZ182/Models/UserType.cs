using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbdullinaPZ18.Models
{
    public class UserType
    {
        [JsonPropertyName("user_type_id")]
        [Key]
        public int UserTypeId { get; private set; }


        [JsonPropertyName("user_type_name")]
        [Required]
        [MaxLength(100)]
        public string UserTypeName { get; set; }


        public bool IsMasterRole()
        {
            return UserTypeName.Equals("Мастер", StringComparison.OrdinalIgnoreCase);
        }
    }
}
