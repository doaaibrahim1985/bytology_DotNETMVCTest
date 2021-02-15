using Blog.IBL;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Blog.BL
{
    public class BlogPostsRepository : IBlogPostsRepository
    {
        private List<BlogModel> blogs = new List<BlogModel>();
        private BlogPostsModel blogPosts = new BlogPostsModel();
        private BlogModel blog = new BlogModel();
        private List<CommentModel> blogcomments = new List<CommentModel>();
        public BlogPostsRepository()
        {

            var json = File.ReadAllText(@"D:\InterviewTasks\Bytology\systems-developer-assessment-master\src\Blog.Data\Blog-Posts.json", System.Text.Encoding.UTF8);
            blogPosts = JsonConvert.DeserializeObject<BlogPostsModel>(json);
            foreach (BlogModel b in blogPosts.blogPosts)
            {
                blogs.Add(b);
            }
        }

        public IEnumerable<BlogModel> Getblogposts()
        {
            return blogs;
            //throw new NotImplementedException();
        }

        public BlogModel getblogpostsbyid(int id)

        {
            foreach (BlogModel b in blogs)
            {
                if (b.id == id)
                {

                    return b;

                }
            }
            throw new NotImplementedException();
        }
        public BlogModel addcomment(CommentModel comment, int id)
        {
            if (id!= 0 || comment!=null)
            {
                
                blog=getblogpostsbyid(id);
                if (blog.comments == null)
                {
                    blog.comments = blogcomments;
                   
                }
               
                blog.comments.Add(comment);
                blogPosts.blogPosts[blogPosts.blogPosts.FindIndex(x => x.id == id)] = blog;
                File.WriteAllText(@"D:\InterviewTasks\Bytology\systems-developer-assessment-master\src\Blog.Data\Blog-Posts.json", JsonConvert.SerializeObject(blogPosts), Encoding.UTF8);


            }
            return getblogpostsbyid(id);
          
        }
        public BlogModel addreply(ReplyModel reply, string commentdate,int id)
        {
            if (id != 0 || reply != null || commentdate != null)
            {

                blog = getblogpostsbyid(id);
                if (blog.comments != null)
                {


                    CommentModel comment = new CommentModel();
                    comment = blog.comments.Where(x => x.date == commentdate).FirstOrDefault();
                    if (comment.replies == null)
                    {
                        List<ReplyModel> replies = new List<ReplyModel>();
                        comment.replies = replies;
                    }
                    comment.replies.Add(reply);
                    blog.comments[blog.comments.FindIndex(x => x.date == commentdate)] = comment;
                    blogPosts.blogPosts[blogPosts.blogPosts.FindIndex(x => x.id == id)] = blog;
                    File.WriteAllText(@"D:\InterviewTasks\Bytology\systems-developer-assessment-master\src\Blog.Data\Blog-Posts.json", JsonConvert.SerializeObject(blogPosts), Encoding.UTF8);

                }
                }
                return getblogpostsbyid(id);
            
        }
    }
}
