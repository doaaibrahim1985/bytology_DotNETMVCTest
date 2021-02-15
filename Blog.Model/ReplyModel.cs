using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{
   public  class ReplyModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string message { get; set; }
    }
}
