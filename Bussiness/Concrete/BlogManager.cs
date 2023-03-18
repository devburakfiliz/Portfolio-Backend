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
    public class BlogManager : IBlogService
    {
        public IResult Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Blog>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
