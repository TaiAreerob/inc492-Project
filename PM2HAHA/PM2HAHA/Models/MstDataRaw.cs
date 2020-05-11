using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM2HAHA.Models
{
   
        [Table("MstDataRaw")]
        public partial class MstDataRaw
    {
        
            [Key, Column("id")]
            public Guid Id { get; set; }

            [Column("aqi")]
            public int Aqi { get; set; }

            [Column("idx")]
            public int Idx { get; set; }
        
            [Column("city")]
            [StringLength(255)]
            public string City { get; set; }

            [Column("longitude")]
            public Decimal Longitude { get; set; }

            [Column("latitude")]
            public Decimal Latitude { get; set; }

            [Column("co")]
             public Decimal Co { get; set; }

            [Column("h")]
            public int H { get; set; }

            [Column("no2")]
            public Decimal No2 { get; set; }

            [Column("o3")]
            public Decimal O3 { get; set; }

            [Column("p")]
             public Decimal P { get; set; }
        
            [Column("pm10")]
            public int Pm10 { get; set; }

            [Column("pm25")]
            public int Pm25 { get; set; }

            [Column("so2")]
            public Decimal So2 { get; set; }

            [Column("t")]
            public Decimal T { get; set; }

            [Column("w")]
            public Decimal W { get; set; }

            [Column("time")]
            public DateTime time { get; set; }

            [Column("CreateAt")]
            public DateTime CreateAt { get; set; }

            [Column("UploadAt")]
             public DateTime UploadAt { get; set; }
    }
    
}
