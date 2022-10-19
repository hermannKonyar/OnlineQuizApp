using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        [Required]
        public string Text { get; set; }
        public IEnumerable<Choice> Choices { get; set; }

        public string? ImageUrl { get; set; }

        public virtual Choice Choice { get; set; }


    }
}
