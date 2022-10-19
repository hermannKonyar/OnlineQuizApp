using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Class
    {
        public int ClassID { get; set; }
        public string Name { get; set; }
        public string TeacherID { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
