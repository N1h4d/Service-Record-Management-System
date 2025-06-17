using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonalInformationManager : IPersonalInformationService
    {
        private readonly IPersonalInformationDal _personalInformationDal;

        public PersonalInformationManager(IPersonalInformationDal personalInformationDal)
        {
            _personalInformationDal = personalInformationDal;
        }

        public IResult Add(PersonalInformation personalInformation)
        {
            _personalInformationDal.Add(personalInformation);
            return new SuccessResult("Personal information added successfully.");
        }

        public IResult Delete(PersonalInformation personalInformation)
        {
            _personalInformationDal.Delete(personalInformation);
            return new SuccessResult("Personal information deleted successfully.");
        }

        [CacheAspect]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<PersonalInformation> GetById(int id)
        {
            var data = _personalInformationDal.Get(p => p.PersonalInformationId == id);
            if (data == null)
                return new ErrorDataResult<PersonalInformation>("Personal information not found.");
            return new SuccessDataResult<PersonalInformation>(data);
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<PersonalInformation>> GetList()
        {
            var data = _personalInformationDal.GetList();
            return new SuccessDataResult<List<PersonalInformation>>(data.ToList());
        }

        public IResult Update(PersonalInformation personalInformation)
        {
            _personalInformationDal.Update(personalInformation);
            return new SuccessResult("Personal information updated successfully.");
        }
    }
}
