﻿using StarWarsApiCSharp;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace StarWarsWebApi.Models
{
    public class PersonDbModel : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PrivateId { get; init; }
       

        [JsonProperty]
        public new IList<string> Films { get; set; }

        [JsonProperty]
        public new IList<string> Species { get; set; }

        [JsonProperty]
        public new IList<string> Starships { get; set; }

        [JsonProperty]
        public new IList<string> Vehicles { get; set; }

        protected override string EntryPath => "people/";
    }
}
