using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class SuperHero
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbilies { get; set; }
        public string secondaryAbilities { get; set; }
        public string catchphrase { get; set; }
    }
}