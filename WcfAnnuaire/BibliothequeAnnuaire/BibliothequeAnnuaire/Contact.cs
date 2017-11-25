using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeAnnuaire
{
    [Table("Contact")]
    public class Contact
    {
        #region attribut
        private int idContact;

        [Key]
        public int IdContact
        {
            get { return idContact; }
            set { idContact = value; }
        }

        private string nomContact;

        public string NomContact
        {
            get { return nomContact; }
            set { nomContact = value; }
        }
        private string prenomContact;

        public string PrenomContact
        {
            get { return prenomContact; }
            set { prenomContact = value; }
        }

        private string telPortContact;

        [DataType(DataType.PhoneNumber)]
        public string TelPortContact
        {
            get { return telPortContact; }
            set { telPortContact = value; }
        }

        private string telBurContact;

        [DataType(DataType.PhoneNumber)]
        public string TelBurContact
        {
            get { return telBurContact; }
            set { telBurContact = value; }
        }

        #endregion

        #region propriétés
        /// <summary>
        /// initie un Contact
        /// </summary>
        /// <param name="nomContact">Nom du nouveau contact</param>
        /// <param name="prenomContact">Prenom du nouveau contact</param>
        /// <param name="telPortContact">Téléphone portable du contact</param>
        /// <param name="telBurContact">Téléphone de bureau du contact</param>
        public Contact(string nomContact, string prenomContact, string telPortContact, string telBurContact)
        {
            this.nomContact = nomContact;
            this.prenomContact = prenomContact;
            this.telPortContact = telPortContact;
            this.telBurContact = telBurContact;
        }
#endregion
    }

}
