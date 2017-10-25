using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WS.Models;

namespace WS.Config
{
    public class account_config : EntityTypeConfiguration<account>
    {
        public account_config()
        {
            HasKey(t => t.id);

            // Properties
            Property(t => t.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            ToTable("account");
        }
    }
}