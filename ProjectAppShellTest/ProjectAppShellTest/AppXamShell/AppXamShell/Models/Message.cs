using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppXamShell.Models
{
    public class MessageModel
    {
        [JsonProperty("text")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string User
        {
            get;
            set;
        }

        [JsonIgnore]
        public DateTime TimeReceived
        {
            get;
            set;
        }

        public bool IsOwnMessage 
        { 
            get; 
            set; 
        }

        public bool IsSystemMessage 
        { 
            get; 
            set; 
        }
    }
}
