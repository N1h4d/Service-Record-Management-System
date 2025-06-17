using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProfessionalDevelopmentDal : EfEntityRepositoryBase<ProfessionalDevelopment, MilitaryDbContext>, IProfessionalDevelopmentDal
    {
       
    }
}
