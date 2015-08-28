using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    [Table("PATIENTS", Schema = "dbo")]
    public class Patient : Personne
    {
        // les Rvs du client
        public virtual ICollection<Rv> Rvs { get; set; }
    }
    }
