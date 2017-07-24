using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEvernote.Common
{
    [Table("Categories")]
    public class Category :EntityBase
    {
        [Required,StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        //bir categorinin birden fazla notları vardır bu nedenle notes objectsi property olarak verilmelidir.
        //lişkili oldugu için virtual olarak tanımlanılır
        public virtual List<Note> Notes { get; set; }

        public Category()
        {
            Notes=new List<Note>();
        }
    }
}
