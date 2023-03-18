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
    public class SkillManager : ISkillService
    {

        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public IResult Add(Skill entity)
        {
            _skillDal.Add(entity);
            return new SuccessResult(Messages.SkillAdded);
        }

        public IResult Delete(Skill entity)
        {
            _skillDal.Delete(entity);
            return new SuccessResult(Messages.SkillDeleted);
        }

        public IDataResult<List<Skill>> GetAll()
        {
            return new SuccessDataResult<List<Skill>>(_skillDal.GetAll(), Messages.SkillImagListed);
        }

        public IResult Update(Skill entity)
        {
            _skillDal.Update(entity);
            return new SuccessResult(Messages.SkillUpdated);
        }
    }
}
