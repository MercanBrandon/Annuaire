using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeAnnuaire
{

    [Table("Ville")]
    public class Ville
    {


        #region Attributs
        private int cp;
        private string libelle; 
        #endregion


        #region Propriétés
        [Key, StringLength(5, MinimumLength = 5)]
        public int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        [Required]
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        #endregion


        #region Constructeur
        /// <summary>
        /// Constructeur par défaut 
        /// </summary>
        public Ville()
        {

        }

        /// <summary>
        /// Constructeur par défaut avec paramètre
        /// </summary>
        /// <param name="LibelleVille"></param>
        public Ville(string LibelleVille)
        {
            this.libelle = LibelleVille;
        } 
        #endregion


    }
}
