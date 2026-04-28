using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welcomeCanada.Models
{
    public class Guide
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        public GuideCategorie Categorie { get; set; }

        public TypeUtilisateur TypeUtilisateur { get; set; }
    }
}