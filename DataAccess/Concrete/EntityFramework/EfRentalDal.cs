using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from r in context.Rentals
        //                     join c in context.Cars
        //                     on r.
        //    }
        //}
    }
}
