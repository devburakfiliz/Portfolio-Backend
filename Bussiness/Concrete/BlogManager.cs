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
   

    public class BlogManager : IBlogService
    {

        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public IResult Add(Blog entity)
        {
            _blogDal.Add(entity);
            return new SuccessResult(Messages.BlogAdded);
        }

        public IResult Delete(Blog entity)
        {
            _blogDal.Delete(entity);
            return new SuccessResult(Messages.BlogDeleted);
        }

        public IDataResult<List<Blog>> GetAll()
        {
            return new SuccessDataResult<List<Blog>>(_blogDal.GetAll(), Messages.BlogListed);
        }

        public IResult Update(Blog entity)
        {
            _blogDal.Update(entity);
            return new SuccessResult(Messages.BlogUpdated);
        }
    }
}
