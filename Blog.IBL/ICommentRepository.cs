using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.IBL
{
    public interface ICommentRepository
    {
        IEnumerable<CommentModel> GetallCommentModels(int blogid);
        int addcomment(CommentModel comment);
        CommentModel addreply(ReplyModel reply, int commentid);
    }
}
