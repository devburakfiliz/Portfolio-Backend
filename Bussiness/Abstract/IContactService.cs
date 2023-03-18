using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();
        IResult Update(Contact entity);
        IResult Delete(Contact entity);
        IResult Add(Contact entity);
    }
}
