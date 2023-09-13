﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameWork.Models {
   public class Book {
        public int Id { get; set; }  //主キー

        [Required]

        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Auther Author{ get; set; }
    }
}
