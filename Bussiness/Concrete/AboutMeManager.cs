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
    public class AboutMeManager : IAboutService
    {
        public IResult Add(AboutMe entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AboutMe entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AboutMe>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(AboutMe entity)
        {
            throw new NotImplementedException();
        }
    }
}
