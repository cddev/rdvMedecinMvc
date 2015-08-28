using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    [Table("CRENEAUX", Schema = "dbo")]
    public class Creneau
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }

        [Required]
        [Column("HDEBUT")]
        public int Hdebut { get; set; }

        [Required]
        [Column("MDEBUT")]
        public int Mdebut { get; set; }

        [Required]
        [Column("HFIN")]
        public int Hfin { get; set; }

        [Required]
        [Column("MFIN")]
        public int Mfin { get; set; }

        [Required]
        [Column("MEDECIN_ID")]
        public int MedecinId { get; set; }

        [Required]
        [ForeignKey("MedecinId")]
        public virtual Medecin Medecin { get; set; }
        
        // les Rvs du créneau
        public ICollection<Rv> Rvs { get; set; }

        [Column("TIMESTAMP")]
        [Timestamp]
        public byte[] Timestamp { get; set; }

    }
}