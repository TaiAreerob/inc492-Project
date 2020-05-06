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

            [Column("Time")]

            public DateTime Time { get; set; }

            [Column("pm2")]

            public int pm2 { get; set; }
        
            [Column("pm10")]

            public int pm10 { get; set; }

            [Column("humidity")]

            public Decimal humidity { get; set; }
            [Column("temp")]

            public Decimal temp { get; set; }
            [Column("districts")]

             public int districts { get; set; }

            [Column("CreateAt")]

            public DateTime CreateAt { get; set; }

            [Column("UploadAt")]

            public DateTime UploadAt { get; set; }



        }
    
}
