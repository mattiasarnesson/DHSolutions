using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DHSolutionsWeb.Models
{
    public partial class Games
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Titel")]
        public string title { get; set; }

        [DisplayName("Beskrivning")]
        public string desc { get; set; }

        [DisplayName("Lanseringsdatum")]
        public System.DateTime realease_year { get; set; }

        [DisplayName("Bild(URL)")]
        public string img_url { get; set; }
    }
}