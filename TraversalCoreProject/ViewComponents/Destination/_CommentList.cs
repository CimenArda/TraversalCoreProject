using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _CommentList :ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly Context _context;

        public _CommentList(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = _context.Comments.Where(x=>x.DestinationID== id).Count();    


            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
