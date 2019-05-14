
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using BotanicalsWebAPI.Models;


namespace BotanicalsWebAPI.Services
{
    public class BotanicalService
    {
        private Dictionary<string, Botanical> botanicals;

        public BotanicalService()
        {
            this.botanicals = new Dictionary<string, Botanical>();

            this.botanicals.Add("100", new Botanical("100", "Rose"));
            this.botanicals.Add("200", new Botanical("200", "Lily"));
            this.botanicals.Add("300", new Botanical("300", "Lavender"));
        }

        public List<Botanical> getAll() {

            List<Botanical> items = new List<Botanical>();

            foreach(KeyValuePair<string, Botanical> item in this.botanicals) {

                items.Add(item.Value);
            }

            return items;
        }

        public Botanical getBotanical(string id) {

            if (this.botanicals.ContainsKey(id)) {

                return this.botanicals[id];
            }

            return null;
        }

        public Botanical updateBotanical(string id, Botanical value) {

            if (this.botanicals.ContainsKey(id)) {

                this.botanicals.Remove(id);

                this.botanicals.Add(id, value);

                return this.botanicals[id];
            }

            return null;
        }

        public Botanical addBotanical(Botanical value) {

            this.botanicals.Add(value.Id, value);

            return value;
        }

        public Botanical removeBotanical(string id) {

            if (this.botanicals.ContainsKey(id)) {

                Botanical originalValue = this.botanicals[id];

                this.botanicals.Remove(id);
                
                return originalValue;
            }

            return null;
        }

    }
}