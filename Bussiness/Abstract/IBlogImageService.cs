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
    public interface IBlogImageService
    {
        IResult Add(IFormFile file, BlogImage blogImage);
        IResult Delete(BlogImage blogImage);
        IResult Update(IFormFile file, BlogImage blogImage);
        IDataResult<List<BlogImage>> GetByBlogId(int blogId);
        IDataResult<BlogImage> GetByImageId(int imageId);
        IDataResult<List<BlogImage>> GetAll();
    }
}
