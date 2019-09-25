using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSVersion1Project.Models
{
    public class RequestLine
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int RequestId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [JsonIgnore]
        public virtual Request Request { get; set; }
        public virtual Product Product { get; set; }

    }
}
