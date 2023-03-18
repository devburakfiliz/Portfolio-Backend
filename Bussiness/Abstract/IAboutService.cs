using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IAboutService
    {
        IDataResult<List<AboutMe>> GetAll();
        IResult Update(AboutMe entity);
        IResult Delete(AboutMe entity);
        IResult Add(AboutMe entity);
    }
}
