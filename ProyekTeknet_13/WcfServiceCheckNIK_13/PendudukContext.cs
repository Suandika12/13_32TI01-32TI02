﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceCheckNIK_13;

namespace WcfServiceCheckNIK_13
{
    public class PendudukContext : DbContext
    {
        public DbSet<Data_Penduduk> DataPenduduks { get; set; }
        public PendudukContext() : base("PendudukDataCS")
        {

        }
    }
}