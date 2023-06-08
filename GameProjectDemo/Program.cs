using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ICustomerService customerManager = new CustomerManager(new MernisServiceAdapter());
            //customerManager.Add(new Customer { Id = 1, NationalityId = "11111111111", 
            //    FirstName= "Batuhan", LastName= "Aydos", DateOfBirth =new DateTime(2001,10,29) });

            Customer customer = new Customer();
            customer.Id = 1;
            //Becasu of the false NationalityId the process will be unsuccess
            customer.NationalityId = "111111111111";
            customer.FirstName = "BATUHAN";
            customer.LastName = "AYDOS";
            customer.DateOfBirth = new DateTime(2001, 10, 29);

            Game game = new Game();
            game.Id = 101;
            game.GameName = "Red Dead Redemption 2";
            game.GameFee = 1100;

            Offer offer = new Offer();
            offer.Id = 1001;
            offer.OfferName = "Winter season offer";
            offer.OfferDiscount = 50;

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Add(customer);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer);

            Console.ReadLine();
        }
    }
}