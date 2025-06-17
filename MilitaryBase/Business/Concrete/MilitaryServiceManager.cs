using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MilitaryServiceManager : IMilitaryServiceService
    {
        private readonly IMilitaryServiceDal _militaryServiceDal;

        public MilitaryServiceManager(IMilitaryServiceDal militaryServiceDal)
        {
            _militaryServiceDal = militaryServiceDal;
        }

        public IResult Add(MilitaryServiceDto dto)
        {
            var entity = new MilitaryService
            {
                PersonalInformationId = dto.PersonalInformationId,
                MilitaryRank = dto.MilitaryRank,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                OrderNumber = dto.OrderNumber
            };

            _militaryServiceDal.Add(entity);
            return new SuccessResult("Military service added successfully.");
        }

        public IResult Delete(int id)
        {
            var entity = _militaryServiceDal.Get(m => m.Id == id);
            if (entity == null)
                return new ErrorResult("Military service not found.");

            _militaryServiceDal.Delete(entity);
            return new SuccessResult("Military service deleted successfully.");
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<MilitaryService> GetById(int id)
        {
            var data = _militaryServiceDal.Get(m => m.Id == id);
            if (data == null)
                return new ErrorDataResult<MilitaryService>("Military service not found.");

            return new SuccessDataResult<MilitaryService>(data);
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<MilitaryService>> GetList()
        {
            var data = _militaryServiceDal.GetList().ToList();
            return new SuccessDataResult<List<MilitaryService>>(data);
        }

        public IResult Update(int id, MilitaryServiceDto dto)
        {
            var entity = _militaryServiceDal.Get(m => m.Id == id);
            if (entity == null)
                return new ErrorResult("Military service not found.");

            entity.PersonalInformationId = dto.PersonalInformationId;
            entity.MilitaryRank = dto.MilitaryRank;
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;
            entity.OrderNumber = dto.OrderNumber;

            _militaryServiceDal.Update(entity);
            return new SuccessResult("Military service updated successfully.");
        }
    }

}
