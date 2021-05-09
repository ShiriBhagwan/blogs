using PostAndBlogging.Api.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PostAndBlogging.Api.Models.DataManager
{
    public class BlogManager : IDataRepository<Blogs>
    {
        readonly BlogContext _blogContext;

        public BlogManager(BlogContext context)
        {
            _blogContext = context;
        }

        public IEnumerable<Blogs> GetAll()
        {
            return _blogContext.Blogs.ToList();
        }

        public Blogs Get(long id)
        {
            return _blogContext.Blogs.FirstOrDefault(e => e.ID == id);
        }

        public void Add(Blogs entity)
        {
            _blogContext.Blogs.Add(entity);
            _blogContext.SaveChanges();
        }

        public void Update(Blogs blog, Blogs entity)
        {
            blog.Title = entity.Title;
            blog.Content = entity.Content;
            blog.CreationDate = entity.CreationDate;
            blog.Updatedate = entity.Updatedate;
            blog.Email = entity.Email;

            _blogContext.SaveChanges();
        }

        public void Delete(Blogs blog)
        {
            _blogContext.Blogs.Remove(blog);
            _blogContext.SaveChanges();
        }
    }
}
