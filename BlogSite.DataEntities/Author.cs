using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataEntities
{
    [Table("Author")]
    public class Author
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string NameSurname { get; set; }

        [Required, StringLength(250)]
        public string AuthorAbout { get; set; }

        [Required, StringLength(250)]
        public string Image { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string FacebookAdress { get; set; }
        [Required, StringLength(50)]
        public string TwitterAdress { get; set; }
        [Required, StringLength(50)]

        public string InstagramAdress { get; set; }

        [Required, StringLength(50)]

        public string Role { get; set; }
    }
}
