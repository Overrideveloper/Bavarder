using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bavarder.Models.ChatModels
{
    public class ChatMessage
    {
        public string Username { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}