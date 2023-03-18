using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BlogImageManager : IBlogImageService
    {

        IBlogImageDal _blogImageDal;

        public BlogImageManager(IBlogImageDal blogImageDal)
        {
            _blogImageDal = blogImageDal;
        }

        public IResult Add(BlogImage entity)
        {
            _blogImageDal.Add(entity);
            return new SuccessResult(Messages.BlogImageAdded);
        }

        public IResult Delete(BlogImage entity)
        {
            _blogImageDal.Delete(entity);
            return new SuccessResult(Messages.BlogImageDeleted);
        }

        public IDataResult<List<BlogImage>> GetAll()
        {
            return new SuccessDataResult<List<BlogImage>>(_blogImageDal.GetAll(), Messages.BlogImageListed);
        }

        public IResult Update(BlogImage entity)
        {
            _blogImageDal.Update(entity);
            return new SuccessResult(Messages.BlogImageUpdated);
        }
    }
}
