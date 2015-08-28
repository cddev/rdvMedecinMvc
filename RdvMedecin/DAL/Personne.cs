using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDVMedecin.DAL
{
    // une personne
    public abstract class Personne
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }

        [Required]
        [MaxLength(5)]
        [Column("TITRE")]
        public string Titre { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("NOM")]
        public string Nom { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("PRENOM")]
        public string Prenom { get; set; }

        [Column("TIMESTAMP")]
        [Timestamp]
        public byte[] Timestamp { get; set; }

    }

}