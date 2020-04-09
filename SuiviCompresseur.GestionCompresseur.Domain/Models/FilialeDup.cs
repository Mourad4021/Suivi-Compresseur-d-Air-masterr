using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace SuiviCompresseur.GestionCompresseur.Domain.Models

{
    public  class FilialeDup
    {
        [Key]
        public Guid FilialeID { get; set; }

        public string Nom { get; set; }

        public string Code { get; set; }





    }
}
