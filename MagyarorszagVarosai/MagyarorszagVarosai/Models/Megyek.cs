﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MagyarorszagVarosai.Models
{
    public partial class Megyek
    {
        public Megyek()
        {
            Telepulesek = new HashSet<Telepulesek>();
        }

        public string Kod { get; set; }
        public string Nev { get; set; }

        public virtual ICollection<Telepulesek> Telepulesek { get; set; }
    }
}
