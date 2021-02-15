using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.IBL
{
    public interface IBlogRepository
    {
        IEnumerable<BlogModel> GetallblogModels();
        int addblog(BlogModel blog);
        BlogModel getblogmodelbyid(int id);
    }
}
