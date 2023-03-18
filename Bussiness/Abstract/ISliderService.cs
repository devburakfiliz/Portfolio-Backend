using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ISliderService
    {
        IDataResult<List<Slider>> GetAll();
        IResult Update(Slider entity);
        IResult Delete(Slider entity);
        IResult Add(Slider entity);
    }
}
