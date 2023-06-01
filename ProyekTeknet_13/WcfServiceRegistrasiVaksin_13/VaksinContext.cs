using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfServiceRegistrasiVaksin_13
{
    public class VaksinContext : DbContext
    {
        public DbSet<VaksinData> VaksinDatas { get; set; }
        public VaksinContext() : base("VaksinDataCS")
        {

        }
    }
}