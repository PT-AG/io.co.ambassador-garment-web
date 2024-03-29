﻿using Moonlay.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufactures.Domain.Shared.ValueObjects
{
    public class BuyerBrand : ValueObject
    {
        public BuyerBrand()
        {

        }

        public BuyerBrand(int buyerId, string code, string name)
        {
            Id = buyerId;
            Code = code;
            Name = name;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
