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
    public class EmploymentHistoryManager : IEmploymentHistoryService
    {
        private readonly IEmploymentHistoryDal _employmentHistoryDal;

        public EmploymentHistoryManager(IEmploymentHistoryDal employmentHistoryDal)
        {
            _employmentHistoryDal = employmentHistoryDal;
        }

        public IResult Add(EmploymentHistoryDto dto)
        {
            var entity = new EmploymentHistory
            {
                PersonalInformationId = dto.PersonalInformationId,
                OrganizationName = dto.OrganizationName,
                Position = dto.Position,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate
            };

            _employmentHistoryDal.Add(entity);
            return new SuccessResult("Employment history added successfully.");
        }

        public IResult Delete(int id)
        {
            var entity = _employmentHistoryDal.Get(e => e.Id == id);
            if (entity == null)
                return new ErrorResult("Employment history not found.");

            _employmentHistoryDal.Delete(entity);
            return new SuccessResult("Employment history deleted successfully.");
        }

        [CacheAspect]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<EmploymentHistory> GetById(int id)
        {
            var data = _employmentHistoryDal.Get(e => e.Id == id);
            if (data == null)
                return new ErrorDataResult<EmploymentHistory>("Employment history not found.");
            return new SuccessDataResult<EmploymentHistory>(data);
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<EmploymentHistory>> GetList()
        {
            var data = _employmentHistoryDal.GetList().ToList();
            return new SuccessDataResult<List<EmploymentHistory>>(data);
        }

        public IResult Update(int id, EmploymentHistoryDto dto)
        {
            var entity = _employmentHistoryDal.Get(e => e.Id == id);
            if (entity == null)
                return new ErrorResult("Employment history not found.");

            entity.PersonalInformationId = dto.PersonalInformationId;
            entity.OrganizationName = dto.OrganizationName;
            entity.Position = dto.Position;
            entity.StartDate = dto.StartDate;
            entity.EndDate = dto.EndDate;

            _employmentHistoryDal.Update(entity);
            return new SuccessResult("Employment history updated successfully.");
        }
    }

}
