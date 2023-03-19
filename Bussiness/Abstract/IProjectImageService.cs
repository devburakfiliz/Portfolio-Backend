using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProjectImageService
    {
        IResult Add(IFormFile file, ProjectImage projectImage);
        IResult Delete(ProjectImage blogImage);
        IResult Update(IFormFile file, ProjectImage projectImage);
        IDataResult<List<ProjectImage>> GetByBlogId(int projectId);
        IDataResult<ProjectImage> GetByImageId(int projectImage);
        IDataResult<List<ProjectImage>> GetAll();
    }
}
