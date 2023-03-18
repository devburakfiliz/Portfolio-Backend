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
    public class SkillImageManager : ISkillImageService
    {

        ISkillImageDal _skillImageDal;

        public SkillImageManager(ISkillImageDal skillImageDal)
        {
            _skillImageDal = skillImageDal;
        }

        public IResult Add(SkillImage entity)
        {
            _skillImageDal.Add(entity);
            return new SuccessResult(Messages.SkillImageAdded);
        }

        public IResult Delete(SkillImage entity)
        {
            _skillImageDal.Delete(entity);
            return new SuccessResult(Messages.SkillImagDeleted);
        }

        public IDataResult<List<SkillImage>> GetAll()
        {
            return new SuccessDataResult<List<SkillImage>>(_skillImageDal.GetAll(), Messages.SkillImagListed);
        }

        public IResult Update(SkillImage entity)
        {
            _skillImageDal.Update(entity);
            return new SuccessResult(Messages.SkillImagUpdated);
        }
    }
}
