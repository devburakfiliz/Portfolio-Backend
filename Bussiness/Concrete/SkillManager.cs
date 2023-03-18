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
    public class SkillManager : ISkillService
    {
        public IResult Add(Skill entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Skill entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Skill>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Skill entity)
        {
            throw new NotImplementedException();
        }
    }
}
