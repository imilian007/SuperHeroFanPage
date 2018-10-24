using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroApplication.Models
{
    public class SuperHero
    {
        [Key]

        public string Name { get; set; }

        public string AlterEgo { get; set; }

        public string PrimaryAbility { get; set; }

        public string SecondaryAbilities{ get; set; }

        public string CatchPhrase { get; set; }
    }
}