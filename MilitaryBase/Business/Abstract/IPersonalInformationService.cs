using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalInformationService
    {
        IDataResult<PersonalInformation> GetById(int id);
        IDataResult<List<PersonalInformation>> GetList();
        IResult Add(PersonalInformation personalInformation);
        IResult Update(PersonalInformation personalInformation);
        IResult Delete(PersonalInformation personalInformation);
    }
}
