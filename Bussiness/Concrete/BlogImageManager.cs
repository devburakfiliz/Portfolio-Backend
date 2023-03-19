using Business.Constants;
using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Business;
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
    public class BlogImageManager : IBlogImageService
    {


        IBlogImageDal _blogImageDal;
        IFileHelper _fileHelper;
        public BlogImageManager(IBlogImageDal blogImageDal, IFileHelper fileHelper)
        {
            _blogImageDal = blogImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, BlogImage carImage)
        {
           
            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
           
            _blogImageDal.Add(carImage);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(BlogImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _blogImageDal.Delete(carImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, BlogImage blogImage)
        {
            blogImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + blogImage.ImagePath, PathConstants.ImagesPath);
            _blogImageDal.Update(blogImage);
            return new SuccessResult();
        }

        public IDataResult<List<BlogImage>> GetByBlogId(int blogId)
        {
            
            return new SuccessDataResult<List<BlogImage>>(_blogImageDal.GetAll(c => c.BlogId == blogId));
        }

        public IDataResult<BlogImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<BlogImage>(_blogImageDal.Get(c => c.Id == imageId));
        }

        public IDataResult<List<BlogImage>> GetAll()
        {
            return new SuccessDataResult<List<BlogImage>>(_blogImageDal.GetAll());
        }

       
    }
}
