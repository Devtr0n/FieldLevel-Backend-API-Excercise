using System;
using System.ComponentModel.DataAnnotations;

namespace FieldLevel.Data
{
    public class RequestStamp
    {
        [Key]
        public int Id { get; set; }

        public DateTime? RequestDate { get; set; }
    }
}