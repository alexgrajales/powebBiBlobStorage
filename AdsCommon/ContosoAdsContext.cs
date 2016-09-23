using System;
using System.Data.Entity;

namespace AdsCommon
{
    public class ContosoAdsContext : DbContext
    {
        public ContosoAdsContext() : base("ContosoAdsContext")
        {
        }

        public ContosoAdsContext(string connString) : base(connString)
        {
        }

        public System.Data.Entity.DbSet<Ad> Ads { get; set; }
    }
}
