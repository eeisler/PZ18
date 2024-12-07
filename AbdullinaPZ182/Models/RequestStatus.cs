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
    public class RequestStatus
    {
        [JsonPropertyName("request_status_id")]
        [Key]
        public int RequestStatusId { get; private set; }


        [JsonPropertyName("request_status_name")]
        [Required]
        [MaxLength(100)]
        public string RequestStatusName { get; set; }
    }
}
