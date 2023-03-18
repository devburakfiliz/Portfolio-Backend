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
    public class AboutMeManager : IAboutService
    {

        IAboutMeDal _aboutMeDal;

        public AboutMeManager(IAboutMeDal aboutMeDal)
        {
            _aboutMeDal = aboutMeDal;
        }

        public IResult Add(AboutMe entity)
        {
            _aboutMeDal.Add(entity);
            return new SuccessResult(Messages.AboutMeAdded);
        }

        public IResult Delete(AboutMe entity)
        {
            _aboutMeDal.Delete(entity);
            return new SuccessResult(Messages.AboutMeDeleted);
        }

        public IDataResult<List<AboutMe>> GetAll()
        {
            return new SuccessDataResult<List<AboutMe>>(_aboutMeDal.GetAll(), Messages.AboutMeListed);
        }

        public IResult Update(AboutMe entity)
        {
            _aboutMeDal.Update(entity);
            return new SuccessResult(Messages.AboutMeUpdated);
        }
    }
}
