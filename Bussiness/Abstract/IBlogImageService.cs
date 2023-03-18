using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBlogImageService
    {
        IDataResult<List<BlogImage>> GetAll();
        IResult Update(BlogImage entity);
        IResult Delete(BlogImage entity);
        IResult Add(BlogImage entity);
    }
}
