using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BotanicalsWebAPI.Models
{
    // Represents an error Response (400, 500 level errors)
    public class ErrorObject
    {
        // This is the name of the field
        public String ErrorDetails { get; set; } 

        public Exception exception {get; set;}
        
        public ErrorObject() {

        }

        public ErrorObject(String details) {
            
            ErrorDetails = details;
        }
    }
}