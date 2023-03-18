using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ISkillService
    {
        IDataResult<List<Skill>> GetAll();
        IResult Update(Skill entity);
        IResult Delete(Skill entity);
        IResult Add(Skill entity);
    }
}
