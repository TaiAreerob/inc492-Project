using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM2HAHA.Models
{
    public class Products
    {
   
        public string client_ip { get; set; }
        public string abbreviation { get; set; }
        public DateTime datetime { get; set; }
        public int day_of_week { get; set; }
        public int day_of_year { get; set; }
        public bool dst { get; set; }

        public int? dst_from { get; set; }
        public int dst_offset { get; set; }
        public int? dst_until { get; set; }
        public int raw_offset { get; set; }

        public string timezone { get; set; }
        public int unixtime { get; set; }
        public DateTime utc_datetime { get; set; }

        public string utc_offset { get; set; }

        public int week_number { get; set; }
        public string[] Sizes { get; set; }
        public string Name { get; set; }
        public DateTime Expiry { get; set; }









    }
}
