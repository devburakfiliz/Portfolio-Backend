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
    public class ContactManager : IContactService
    {
        public IResult Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
