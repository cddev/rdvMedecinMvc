using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDVMedecin.DAL
{
    public class RdvMedecin
    {
        public RdvMedecin() { }

        public int ID { get; set; }

        public DateTime Jour { get; set; }

        public string PatientNom { get; set; }

        public string Horaire { get; set; }
    }
}
