using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x=>x.DestinationID==id);

        }
        public List<Comment> TGetAllList()
        {
            return _commentDal.GetAllList();
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void TRemove(Comment entity)
        {
           _commentDal.Remove(entity);
        }

        public void TUpdate(Comment entity)
        {
           _commentDal.Update(entity);
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
    }
}
