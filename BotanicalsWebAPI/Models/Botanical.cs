using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BotanicalsWebAPI.Models
{
    public class Botanical
    {
        // Id
        public String Id { get; set; }

        // This is the name of the field
        public String Name { get; set; } 

        public Botanical() {

        }

        public Botanical(string id, string name) {
            this.Id = id;
            this.Name = name;
        }
    }
}