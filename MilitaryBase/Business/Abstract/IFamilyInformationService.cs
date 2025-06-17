using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFamilyInformationService
    {
        IDataResult<List<FamilyInformation>> GetList();
        IDataResult<FamilyInformation> GetById(int id);
        IResult Add(FamilyInformationDto dto);
        IResult Update(int id, FamilyInformationDto dto);
        IResult Delete(int id);
    }

}
