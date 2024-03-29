﻿using Manufactures.Domain.Shared.ValueObjects;
using Moonlay.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufactures.Domain.GarmentTradingFinishingIns.ValueObjects
{
    public class GarmentTradingFinishingInItemValueObject : ValueObject
    {
        public Guid Id { get; set; }
        public Guid FinishingInId { get;  set; }
        public Guid SubconCuttingId { get;  set; }
        public Product Product { get;  set; }
        public string DesignColor { get;  set; }
        public SizeValueObject Size { get;  set; }
        public double Quantity { get;  set; }
        public double RemainingQuantity { get;  set; }
        public Uom Uom { get;  set; }
        public string Color { get;  set; }
        public double BasicPrice { get; set; }
        public bool IsSave { get; set; }

        public GarmentTradingFinishingInItemValueObject()
        {

        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
