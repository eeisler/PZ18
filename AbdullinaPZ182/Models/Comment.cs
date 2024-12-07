using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AbdullinaPZ18.Models
{
    public class Comment
    {
        [Key]
        [JsonPropertyName("comment_id")]
        public int CommentId { get; private set; }


        [Required]
        [MaxLength(250)]
        [JsonPropertyName("message")]
        public string Message { get; set; }


        [JsonPropertyName("master_id")]
        [ForeignKey("Master")]
        public int MasterId { get; set; }
        public User Master { get; set; }


        [JsonPropertyName("request_id")]
        [ForeignKey("Request")]
        public int RequestId { get; set; }
        public Request Request { get; set; }



        public bool IsMessageLengthValid()
        {
            return Message.Length <= 250;
        }

    }
}
