using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceConfirmVaccine_13;

namespace WcfServiceConfirmVaccine_13
{
    public class PasienContext : DbContext
    {
        public DbSet<Data_Pasien> data_Pasiens { get; set; }
        public PasienContext() : base("PasienDataCS")
        {

        }
    }
}