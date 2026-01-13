using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LmsModernApp.Models
{
    [Table("BORROWER", Schema = "dbo")]
    public class Borrower
    {
        [Key]
        [Column("BOR_NO")]
        public int BOR_NO { get; set; }

        [Column("BOR_CLASS")]
        public string? BOR_CLASS { get; set; }

        [Column("BOR_GROUP")]
        public string? BOR_GROUP { get; set; }

        [Column("BOR_SURNAME")]
        public string? BOR_SURNAME { get; set; }

        [Column("BOR_GIVEN")]
        public string? BOR_GIVEN { get; set; }

        [Column("BOR_EMAIL")]
        public string? BOR_EMAIL { get; set; }

        [Column("BOR_REGDATE")]
        public DateTime? BOR_REGDATE { get; set; }

        [Column("BOR_LASTACTIVE")]
        public DateTime? BOR_LASTACTIVE { get; set; }

        [Column("BOR_NO_LOANS")]
        public int? BOR_NO_LOANS { get; set; }
    }
}