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
    public class DrivingLicenseManager : IDrivingLicenseService
    {
        private readonly IDrivingLicenseDal _drivingLicenseDal;

        public DrivingLicenseManager(IDrivingLicenseDal drivingLicenseDal)
        {
            _drivingLicenseDal = drivingLicenseDal;
        }

        public IResult Add(DrivingLicenseDto dto)
        {
            var entity = new DrivingLicense
            {
                PersonalInformationId = dto.PersonalInformationId,
                LicenseNumber = dto.LicenseNumber,
                LicenseCategory = dto.LicenseCategory
            };

            _drivingLicenseDal.Add(entity);
            return new SuccessResult("Driving license added successfully.");
        }

        public IResult Delete(int id)
        {
            var entity = _drivingLicenseDal.Get(d => d.Id == id);
            if (entity == null)
                return new ErrorResult("Driving license not found.");

            _drivingLicenseDal.Delete(entity);
            return new SuccessResult("Driving license deleted successfully.");
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<DrivingLicense> GetById(int id)
        {
            var entity = _drivingLicenseDal.Get(d => d.Id == id);
            if (entity == null)
                return new ErrorDataResult<DrivingLicense>("Driving license not found.");

            return new SuccessDataResult<DrivingLicense>(entity);
        }

        [CacheAspect]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<DrivingLicense>> GetList()
        {
            var data = _drivingLicenseDal.GetList().ToList();
            return new SuccessDataResult<List<DrivingLicense>>(data);
        }

        public IResult Update(int id, DrivingLicenseDto dto)
        {
            var entity = _drivingLicenseDal.Get(d => d.Id == id);
            if (entity == null)
                return new ErrorResult("Driving license not found.");

            entity.PersonalInformationId = dto.PersonalInformationId;
            entity.LicenseNumber = dto.LicenseNumber;
            entity.LicenseCategory = dto.LicenseCategory;

            _drivingLicenseDal.Update(entity);
            return new SuccessResult("Driving license updated successfully.");
        }
    }

}
