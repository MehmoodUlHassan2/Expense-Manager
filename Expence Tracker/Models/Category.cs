using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expence_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Title is required.")]
        public string Title { get; set; }
        public string Icon { get; set; }

        public string Type { get; set; }
        [NotMapped]
        public string TitleWithIcon {
            get
            { return this.Icon + " " + this.Title; }
        }
    }
}
