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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;
        IFileHelper _fileHelper;
        public SliderManager(ISliderDal sliderDal, IFileHelper fileHelper)
        {
            _sliderDal = sliderDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, Slider slider)
        {

            slider.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);

            _sliderDal.Add(slider);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(Slider slider)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + slider.ImagePath);
            _sliderDal.Delete(slider);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, Slider slider)
        {
            slider.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + slider.ImagePath, PathConstants.ImagesPath);
            _sliderDal.Update(slider);
            return new SuccessResult();
        }

        public IDataResult<Slider> GetByImageId(int sliderId)
        {
            return new SuccessDataResult<Slider>(_sliderDal.Get(c => c.Id == sliderId));
        }

        public IDataResult<List<Slider>> GetAll()
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetAll());
        }
    }
}
