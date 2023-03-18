using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IResult Update(Project entity);
        IResult Delete(Project entity);
        IResult Add(Project entity);
    }
}
