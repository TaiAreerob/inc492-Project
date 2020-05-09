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
        public string Password { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("stutus")]
        public int Stutus { get; set; }

        [Column("CreateAt")]
        public DateTime CreateAt { get; set; }

        [Column("UploadAt")]
        public DateTime UploadAt { get; set; }



    }
}
