using eTicket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile picture is require")]
        public string ProfilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is require")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be 3 and 50 characters")]
        public string FullName { get; set; }


        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is require")]
        public string Bio { get; set; }

        //Relationsips
        public List<Movie> Movies { get; set; }
    }
}
