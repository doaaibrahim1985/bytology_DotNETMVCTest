using Blog.IBL;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BL
{
   public class commentRepository : ICommentRepository
    {
        public commentRepository()
        {

        }

        public int addcomment(CommentModel comment)
        {
            throw new NotImplementedException();
        }
        public CommentModel addreply(ReplyModel reply,int commentid)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CommentModel> GetallCommentModels(int blogid)
        {
            throw new NotImplementedException();
        }
    }
}
