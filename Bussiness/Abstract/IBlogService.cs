using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IBlogService
    {
        IDataResult<List<Blog>> GetAll();
        IResult Update(Blog entity);
        IResult Delete(Blog entity);
        IResult Add(Blog entity);
    }
}
