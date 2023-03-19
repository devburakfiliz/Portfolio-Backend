using Business.Constants;
using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
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
        IFileHelper _fileHelper;
        public ProjectImageManager(IProjectImageDal projectImageDal, IFileHelper fileHelper)
        {
            _projectImageDal = projectImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, ProjectImage projectImage)
        {

            projectImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);

            _projectImageDal.Add(projectImage);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(ProjectImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _projectImageDal.Delete(carImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, ProjectImage blogImage)
        {
            blogImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + blogImage.ImagePath, PathConstants.ImagesPath);
            _projectImageDal.Update(blogImage);
            return new SuccessResult();
        }

        public IDataResult<List<ProjectImage>> GetByBlogId(int projectId)
        {

            return new SuccessDataResult<List<ProjectImage>>(_projectImageDal.GetAll(c => c.ProjectId == projectId));
        }

        public IDataResult<ProjectImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<ProjectImage>(_projectImageDal.Get(c => c.Id == imageId));
        }

        public IDataResult<List<ProjectImage>> GetAll()
        {
            return new SuccessDataResult<List<ProjectImage>>(_projectImageDal.GetAll());
        }
    }
}
