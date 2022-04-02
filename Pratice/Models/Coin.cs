using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pratice.Models
{
    public class Coin
    {
        
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required]
        public string baseAsset { get; set; }
        [Required]
        public string quoteAsset { get; set; }
        [Required]
        public string volumn24h { get; set; }
        [Required]
        public Market marketId { get; set; }
        [Required]
        public DateTime createdAt { get; set; }
        [Required]
        public DateTime updatedAt { get; set; }
        [Required(ErrorMessage = "Please enter status")]
        public int status { get; set; }

    }
}