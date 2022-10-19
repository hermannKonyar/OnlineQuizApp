using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Choice
    {
        [Key]
        public int ChoiceID { get; set; }
        public string Text { get; set; }
        public string? ImageUrl { get; set; }

    }
}
