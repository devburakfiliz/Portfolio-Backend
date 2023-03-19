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
    public interface ISliderService
    {
        IResult Add(IFormFile file, Slider slider);
        IResult Delete(Slider slider);
        IResult Update(IFormFile file, Slider slider);
        IDataResult<Slider> GetByImageId(int sliderId);
        IDataResult<List<Slider>> GetAll();
    }
}
