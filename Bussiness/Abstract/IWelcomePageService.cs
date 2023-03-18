using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IWelcomePageService
    {
        IDataResult<List<WelcomePage>> GetAll();
        IResult Update(WelcomePage entity);
        IResult Delete(WelcomePage entity);
        IResult Add(WelcomePage entity);
    }
}
