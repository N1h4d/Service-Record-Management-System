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
    public interface IMilitaryServiceService
    {
        IDataResult<List<MilitaryService>> GetList();
        IDataResult<MilitaryService> GetById(int id);
        IResult Add(MilitaryServiceDto dto);
        IResult Update(int id, MilitaryServiceDto dto);
        IResult Delete(int id);
    }

}
