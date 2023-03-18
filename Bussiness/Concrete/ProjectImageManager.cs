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
    public class ProjectImageManager : IProjectImageService
    {

        IProjectImageDal _projectImageDal;

        public ProjectImageManager(IProjectImageDal projectImageDal)
        {
            _projectImageDal = projectImageDal;
        }

        public IResult Add(ProjectImage entity)
        {
            _projectImageDal.Add(entity);
            return new SuccessResult(Messages.ProjectImageAdded);
        }

        public IResult Delete(ProjectImage entity)
        {
            _projectImageDal.Delete(entity);
            return new SuccessResult(Messages.ProjectImageDeleted);
        }

        public IDataResult<List<ProjectImage>> GetAll()
        {
            return new SuccessDataResult<List<ProjectImage>>(_projectImageDal.GetAll(), Messages.ProjectImageListed);

        }

        public IResult Update(ProjectImage entity)
        {
            _projectImageDal.Update(entity);
            return new SuccessResult(Messages.ProjectImageUpdated);
        }
    }
}
