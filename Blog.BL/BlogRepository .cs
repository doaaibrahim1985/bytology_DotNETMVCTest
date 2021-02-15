using Blog.IBL;
using Blog.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BL
{
   public  class BlogRepository : IBlogRepository
    {
        private List<BlogModel> blogs = new List<BlogModel>();
        public BlogRepository()
        {
           
            
        }

        public int addblog(BlogModel blog)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogModel> GetallblogModels()
        {
            return blogs;
           // throw new NotImplementedException();
        }

        public BlogModel getblogmodelbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}
