using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM2HAHA.Models
{
   
        [Table("MstDataProcess")]
        public partial class MstDataProcess
        {
       
            [Key, Column("id")]
            public Guid Id { get; set; }

            [Column("time")]
            public DateTime Time { get; set; }

            [Column("pm2")]
            public int Pm2 { get; set; }

            [Column("pm10")]
            public int Pm10 { get; set; }

            [Column("humidity")]
            public Decimal Humidity { get; set; }

            [Column("temp")]
            public Decimal Temp { get; set; }

            [Column("CreateAt")]
            public DateTime CreateAt { get; set; }

            [Column("UploadAt")]
            public DateTime UploadAt { get; set; }



        }

    }
