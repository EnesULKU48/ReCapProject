using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }

        public int CarName { get; set; }

        public string BrandName { get; set; }

        public string ClorName { get; set; }

        public decimal DailyPrice { get; set; }

    }
}
