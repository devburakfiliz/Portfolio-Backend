﻿using Bussiness.Abstract;
using Core.Utilities.Results;
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
        public IResult Add(WelcomePage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(WelcomePage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WelcomePage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(WelcomePage entity)
        {
            throw new NotImplementedException();
        }
    }
}
