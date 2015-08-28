using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    [Table("RVS", Schema = "dbo")]
    public class Rv
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }

        [Required]
        [Column("JOUR")]
        public DateTime Jour { get; set; }

        [Column("CLIENT_ID")]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        [Required]
        public virtual Patient Patient { get; set; }

        [Column("CRENEAU_ID")]
        public int CreneauId { get; set; }

        [ForeignKey("CreneauId")]
        [Required]
        public virtual Creneau Creneau { get; set; }

        [Column("TIMESTAMP")]
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
