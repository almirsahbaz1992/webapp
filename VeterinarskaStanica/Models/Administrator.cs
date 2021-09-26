using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VeterinasrkaStanica.Helper;

namespace VeterinarskaStanica.Models
{

    public class Administrator : IEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public StrucneSpreme StrucneSpreme { get; set; }

        public virtual KorisnickiNalog KorisnickiNalog { get; set; }

        public int KorisnickiNalogId { get; set; }

        public Gradovi Gradovi { get; set; }

        public int? StrucneSpremeId { get; set; }

        public int? GradoviId { get; set; }
    }
}