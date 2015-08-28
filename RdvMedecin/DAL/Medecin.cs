using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    [Table("MEDECINS", Schema = "dbo")]
    public class Medecin : Personne
    {
        // les créneaux horaires du médecin
        public ICollection<Creneau> Creneaux { get; set; }
    }
}
