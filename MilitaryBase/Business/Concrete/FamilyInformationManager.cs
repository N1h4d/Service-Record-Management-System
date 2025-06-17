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
    public class FamilyInformationManager : IFamilyInformationService
    {
        private readonly IFamilyInformationDal _familyInformationDal;

        public FamilyInformationManager(IFamilyInformationDal familyInformationDal)
        {
            _familyInformationDal = familyInformationDal;
        }

        public IResult Add(FamilyInformationDto dto)
        {
            var entity = new FamilyInformation
            {
                PersonalInformationId = dto.PersonalInformationId,
                Relationship = dto.Relationship,
                FullName = dto.FullName,
                BirthYear = dto.BirthYear,
                Address = dto.Address
            };

            _familyInformationDal.Add(entity);
            return new SuccessResult("Family information added successfully.");
        }

        public IResult Delete(int id)
        {
            var entity = _familyInformationDal.Get(f => f.Id == id);
            if (entity == null)
                return new ErrorResult("Family information not found.");

            _familyInformationDal.Delete(entity);
            return new SuccessResult("Family information deleted successfully.");
        }

        [CacheAspect]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<FamilyInformation> GetById(int id)
        {
            var entity = _familyInformationDal.Get(f => f.Id == id);
            if (entity == null)
                return new ErrorDataResult<FamilyInformation>("Family information not found.");

            return new SuccessDataResult<FamilyInformation>(entity);
        }

        [CacheAspect]
        [LogAspect(typeof(DatabaseLogger))]
        public IDataResult<List<FamilyInformation>> GetList()
        {
            var data = _familyInformationDal.GetList().ToList();
            return new SuccessDataResult<List<FamilyInformation>>(data);
        }

        public IResult Update(int id, FamilyInformationDto dto)
        {
            var entity = _familyInformationDal.Get(f => f.Id == id);
            if (entity == null)
                return new ErrorResult("Family information not found.");

            entity.PersonalInformationId = dto.PersonalInformationId;
            entity.Relationship = dto.Relationship;
            entity.FullName = dto.FullName;
            entity.BirthYear = dto.BirthYear;
            entity.Address = dto.Address;

            _familyInformationDal.Update(entity);
            return new SuccessResult("Family information updated successfully.");
        }
    }

}
