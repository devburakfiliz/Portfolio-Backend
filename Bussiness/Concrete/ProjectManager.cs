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
    public class ProjectManager : IProjectService
    {
        public IResult Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Project>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
