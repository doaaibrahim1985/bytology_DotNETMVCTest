using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{
    public class CommentModel
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string date { get; set; }
        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        public string message { get; set; }
        public List<ReplyModel> replies { get; set; }
    
     
    }
}
