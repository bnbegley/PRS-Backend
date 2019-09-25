using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSVersion1Project.Models
{
    public class Request
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Justification { get; set; }
        public string RejectionReason { get; set; }
        [Required]
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual List<RequestLine> RequestLines { get; set; }

    }
}
