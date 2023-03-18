using Bussiness.Abstract;
using Core.Utilities.Results;
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
        public IResult Add(BlogImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BlogImage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BlogImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(BlogImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
