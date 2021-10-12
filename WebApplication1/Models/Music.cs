
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Music
    {
   
        [Key]
        public int MusicId { get; set; }
        [Required(ErrorMessage = "El nombre de la cancion es requerido")]
        [StringLength (60, MinimumLength =3, ErrorMessage="El nombre de la cancion debe tener mas de 3 letras")]
        [Display(Name = "Nombre completo de la cancion")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El nombre del autor es requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre del autor debe tener mas de 3 letras")]
        [Display(Name = "Nombre del autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El nombre del autor es requerido")]
        [Display(Name = "Letra")]
        public string Letra { get; set; }



    }
}
