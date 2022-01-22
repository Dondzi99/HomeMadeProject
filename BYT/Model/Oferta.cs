using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BYT.Model
{
    public class Oferta
    {
        private long m_ID;
        private string m_Nazwa;
        private string m_Stawka;
        private string m_Adres;
        private string m_Email;
        private string m_Telefon;
        private string m_Opis;

        [Key]
        public long ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }

        [Required]
        public string Nazwa
        {
            get
            {
                return m_Nazwa;
            }

            set
            {
                m_Nazwa = value;
            }
        }

        [Required]
        public string Stawka
        {
            get
            {
                return m_Stawka;
            }

            set
            {
                m_Stawka = value;
            }
        }

        [Required]
        public string Adres
        {
            get
            {
                return m_Adres;
            }

            set
            {
                m_Adres = value;
            }
        }

        [Required]
        public string Email
        {
            get
            {
                return m_Email;
            }

            set
            {
                m_Email = value;
            }
        }

        public string Telefon
        {
            get
            {
                return m_Telefon;
            }

            set
            {
                m_Telefon = value;
            }
        }

        public string Opis
        {
            get
            {
                return m_Opis;
            }

            set
            {
                m_Opis = value;
            }
        }
    }
}
