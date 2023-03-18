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
    public class ContactManager : IContactService
    {

        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact entity)
        {
            _contactDal.Add(entity);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Delete(Contact entity)
        {
            _contactDal.Delete(entity);
            return new SuccessResult(Messages.ContactDeleted);
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(), Messages.ContactListed);

        }

        public IResult Update(Contact entity)
        {
            _contactDal.Update(entity);
            return new SuccessResult(Messages.ContactUpdated);
        }
    }
}
