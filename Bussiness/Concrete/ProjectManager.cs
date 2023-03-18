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
    public class ProjectManager : IProjectService
    {

        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(Project entity)
        {
            _projectDal.Add(entity);
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Delete(Project entity)
        {
            _projectDal.Delete(entity);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetAll(), Messages.ProjectListed);
        }

        public IResult Update(Project entity)
        {
            _projectDal.Update(entity);
            return new SuccessResult(Messages.ProjectUpdated);
        }
    }
}
