using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM2HAHA.Models
{
  
        [Table("MstRsi")]
        public partial class MstRsi
    {
            [Key, Column("id")]
            public Guid Id { get; set; }

            [Column("period")]

            public int period { get; set; }

            [Column("higilevel")]

            public int higilevel { get; set; }

            [Column("lowlevel")]

            public int lowlevel { get; set; }

            [Column("usercreate")]

            public Guid usercreate { get; set; }

            [Column("CreateAt")]

            public DateTime CreateAt { get; set; }

            [Column("UploadAt")]

            public DateTime UploadAt { get; set; }



        }
    
}
