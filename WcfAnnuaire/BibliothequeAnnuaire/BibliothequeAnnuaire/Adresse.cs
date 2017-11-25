using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeAnnuaire
{

    [Table("Adresse")]
    public class Adresse
    {
        #region Attributs
        private int idAdresse;
        private string libAdresse;
        private string ligne2;
        private string complementAdresse;
        private int cpAdresse; 
        #endregion


        #region Propriétés
        [Key]
        public int IdAdresse
        {
            get { return idAdresse; }
            set { idAdresse = value; }
        }


        [Required, StringLength(200)]
        public string Ligne1
        {
            get { return libAdresse; }
            set { libAdresse = value; }
        }


        [StringLength(200)]
        public string Ligne2
        {
            get { return ligne2; }
            set { ligne2 = value; }
        }

        [StringLength(200)]
        public string ComplementAdresse
        {
            get { return complementAdresse; }
            set { complementAdresse = value; }
        }

        public int CpAdresse
        {
            get { return cpAdresse; }
            set { cpAdresse = value; }
        }

        [ForeignKey("CpAdresse")]
        public Ville Ville { get; set; }
        #endregion


        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Adresse()
        {

        }

        /// <summary>
        /// Constructeur avec paramètre
        /// </summary>
        /// <param name="Ligne1Adresse">Ligne d'adresse 1</param>
        /// <param name="Ligne2Adresse">Ligne d'adresse 2</param>
        /// <param name="ComplementAdresse">Complément d'adresse</param>
        /// <param name="CodePostalAdresse">Le code postal de l'adresse</param>
        public Adresse(string Ligne1Adresse, string Ligne2Adresse, string ComplementAdresse, int CodePostalAdresse)
        {
            this.Ligne1 = Ligne1Adresse;
            this.Ligne2 = Ligne2Adresse;
            this.ComplementAdresse = ComplementAdresse;
            this.CpAdresse = CodePostalAdresse;
        } 
        #endregion

    }
}
