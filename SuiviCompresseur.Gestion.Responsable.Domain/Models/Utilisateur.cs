using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuiviCompresseur.Gestion.Responsable.Domain.Models
{
   public  class Utilisateur
    {
        [Key]
        public Guid UtilisateurID { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+/([a-zA-Z0-9-]+\\.)+/([a-zA-Z0-9-]+\\.)}$", ErrorMessage = "E-mail_Lotus is not valid")]
        [RegularExpression("^[a-zA-Z ]*/[a-zA-Z]*/[a-zA-Z]*$", ErrorMessage = "E-mail_Lotus is not valid")]
        public string Mail_Lotus { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string MotDePasse { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date_Ajout { get; set; }


        public Guid FilialeID { get; set; }
        public Filiale Filiale { get; set; }





    }
}