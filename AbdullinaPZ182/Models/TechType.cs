using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace AbdullinaPZ18.Models
{
    public class TechType
    {
        [JsonPropertyName("tech_type_id")]
        [Key]
        public int TechTypeId { get; private set; }


        [JsonPropertyName("tech_type_name")]
        [Required]
        [MaxLength(100)]
        public string TechTypeName { get; set;}
    }
}
