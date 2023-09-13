using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleEntityFrameWork.Models {
   public class Auther {
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        public DateTime birthday { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Book>Books  { get; set; }
    }
}
