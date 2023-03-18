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

    public class WelcomePageManager : IWelcomePageService
    {

        IWelcomePageDal _welcomePageDal;

        public WelcomePageManager(IWelcomePageDal welcomePageDal)
        {
            _welcomePageDal = welcomePageDal;
        }

        public IResult Add(WelcomePage entity)
        {
            _welcomePageDal.Add(entity);
            return new SuccessResult(Messages.TextAdded);
        }

        public IResult Delete(WelcomePage entity)
        {
            _welcomePageDal.Delete(entity);
            return new SuccessResult(Messages.TextDeleted);
        }

        public IDataResult<List<WelcomePage>> GetAll()
        {
            return new SuccessDataResult<List<WelcomePage>>(_welcomePageDal.GetAll(), Messages.TextListed);
        }

        public IResult Update(WelcomePage entity)
        {
            _welcomePageDal.Update(entity);
            return new SuccessResult(Messages.TextUpdated);
        }
    }
}
