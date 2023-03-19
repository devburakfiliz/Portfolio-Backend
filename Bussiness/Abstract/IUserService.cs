using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User entity);
        IDataResult<List<User>> GetAll();

        IResult Add(User entity);
        IResult Update(User entity);
        IResult UpdatePassword(User entity, string password);
        IResult Delete(User entity);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetById(int id);
    }
}
