using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AbdullinaPZ18.Models
{
    public class Request
    {
        [Key]
        [JsonPropertyName("request_id")]
        public int RequestId {  get; private set; }


        [JsonPropertyName("start_date")]
        [Required]
        public DateTime? StartDate { get; set; }


        [JsonPropertyName("tech_type_id")]
        [ForeignKey("TechType")]
        public int TechTypeId { get; set; }
        public TechType TechType { get; set; }


        [JsonPropertyName("tech_model")]
        [Required]
        public string TechModel { get; set; }


        [JsonPropertyName("problem")]
        [Required]
        [MaxLength(100)]
        public string Problem {  get; set; }


        [JsonPropertyName("request_status_id")]
        [ForeignKey("RequestStatus")]
        public int RequestStatusId { get; set; }
        public RequestStatus RequestStatus { get; set; }


        [JsonPropertyName("complete_date")]
        public DateTime? CompleteDate { get; set; }           // to do: check wether the complete date is more than start date           


        [JsonPropertyName("parts")]
        [MaxLength(100)]
        public string Parts { get; set; }


        [JsonPropertyName("master_id")]
        [ForeignKey("Master")]                             // to do: make validation if not master deny
        public int MasterId { get; set; }
        public User Master { get; set; }


        [JsonPropertyName("client_id")]
        [ForeignKey("Client")]                             // to do: the same as above but for client
        public int ClientId { get; set; }
        public User Client { get; set; }


        public bool IsCompleted()
        {
            return CompleteDate.HasValue && RequestStatusId == 3;
        }
    }
}
