﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class Translation
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Culture { get; set; }

    }
}
