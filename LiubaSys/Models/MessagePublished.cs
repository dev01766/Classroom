﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiubaSys.Models
{
    public class MessagePublished
    {
        public int MessagePublishedId { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public string File1 { get; set; }
        public string YoutubeLink1 { get; set; }

        // Navigational properties
        public ApplicationUser User { get; set; }
        public virtual ICollection<MessagesInClassroom> MessagesInClassroom { get; set; }
    }
}
