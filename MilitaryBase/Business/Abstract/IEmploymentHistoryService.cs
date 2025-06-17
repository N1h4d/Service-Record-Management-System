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
    public interface IEmploymentHistoryService
    {
        IDataResult<List<EmploymentHistory>> GetList();
        IDataResult<EmploymentHistory> GetById(int id);
        IResult Add(EmploymentHistoryDto dto);
        IResult Update(int id, EmploymentHistoryDto dto);
        IResult Delete(int id);
    }

}
