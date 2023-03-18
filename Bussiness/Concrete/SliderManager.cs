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
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IResult Add(Slider entity)
        {
            _sliderDal.Add(entity);
            return new SuccessResult(Messages.SliderAdded);
        }

        public IResult Delete(Slider entity)
        {
            _sliderDal.Delete(entity);
            return new SuccessResult(Messages.SliderDeleted);
        }

        public IDataResult<List<Slider>> GetAll()
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetAll(), Messages.SkillImagListed);

        }

        public IResult Update(Slider entity)
        {
            _sliderDal.Update(entity);
            return new SuccessResult(Messages.SliderUpdated);
        }
    }
}
