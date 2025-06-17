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
    public interface IDrivingLicenseService
    {
        IDataResult<List<DrivingLicense>> GetList();
        IDataResult<DrivingLicense> GetById(int id);
        IResult Add(DrivingLicenseDto dto);
        IResult Update(int id, DrivingLicenseDto dto);
        IResult Delete(int id);
    }

}
