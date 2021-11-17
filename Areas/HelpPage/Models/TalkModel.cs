using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheCodeCamp.Areas.HelpPage.Models
{
    public class TalkModel
    {
        [Required]
        public int TalkId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(4096, MinimumLength = 50)]
        public string Abstract { get; set; }
        [Range(100,500)]
        [Required]
        public int Level { get; set; }
        public SpeakerModel Speaker { get; set; }
    }
}