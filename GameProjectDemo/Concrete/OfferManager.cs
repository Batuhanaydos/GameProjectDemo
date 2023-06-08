using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Offer discount added to library" + " " + offer.OfferName + " " + offer.OfferDiscount);
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Offer discount deleted to library" + " " + offer.OfferName + " " + offer.OfferDiscount);
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Offer discount updated to library" + " " + offer.OfferName + " " + offer.OfferDiscount);
        }

    }
}