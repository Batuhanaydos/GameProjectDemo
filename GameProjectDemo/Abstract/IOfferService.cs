using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer);
    }
}