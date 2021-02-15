using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Model
{
    public class BlogModel
    {
        public int id { get; set; }
       
        public string date { get; set; }

        public string title { get; set; }
        public string image { get; set; }
        public string htmlContent { get; set; }
        public List<CommentModel>  comments { get; set; }

    }
}
