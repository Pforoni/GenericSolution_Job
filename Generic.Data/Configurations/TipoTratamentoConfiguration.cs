﻿using Generic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class TipoTratamentoConfiguration : EntityBaseConfiguration<TiposTratamento>
    {
        public TipoTratamentoConfiguration()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(50);
        }
    }
}