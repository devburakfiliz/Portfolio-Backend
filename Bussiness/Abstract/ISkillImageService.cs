using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ISkillImageService
    {
        IDataResult<List<SkillImage>> GetAll();
        IResult Update(SkillImage entity);
        IResult Delete(SkillImage entity);
        IResult Add(SkillImage entity);
    }
}
