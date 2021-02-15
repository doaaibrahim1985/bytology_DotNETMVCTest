using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Model;

namespace Blog.IBL
{
    
    public interface IBlogPostsRepository
    {
        IEnumerable<BlogModel> Getblogposts();
        BlogModel getblogpostsbyid(int id);
        BlogModel addcomment(CommentModel comment,int id);
        BlogModel addreply(ReplyModel reply, string commentdate, int id);
    }
}
