﻿using Generic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Data.Configurations
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    //public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.ID);
            Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
