using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProjectImageService
    {
        IDataResult<List<ProjectImage>> GetAll();
        IResult Update(ProjectImage entity);
        IResult Delete(ProjectImage entity);
        IResult Add(ProjectImage entity);
    }
}
