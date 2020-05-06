using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM2HAHA.Models
{
    [Table("MSTUsers")]
    public partial class MstUsers
    {
       [Key, Column("id")]
        public Guid Id { get; set; }

        [Column("usernamr")]

        public string Username { get; set; }

        [Column("password")]

        public string password { get; set; }

        [Column("name")]

        public string Name { get; set; }

        [Column("lastname")]

        public string Lastname { get; set; }

        [Column("phone")]

        public string phone { get; set; }

        [Column("email")]

        public string email { get; set; }

        [Column("stutus")]

        public int stutus { get; set; }

        [Column("CreateAt")]

        public DateTime CreateAt { get; set; }

        [Column("UploadAt")]

        public DateTime UploadAt { get; set; }



    }
}
