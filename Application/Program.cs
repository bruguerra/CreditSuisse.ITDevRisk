using Application.Configuration;
using Application.Interfaces;
using Application.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ServicesConfig.ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var tradeAppService = serviceProvider.GetRequiredService<ITradeAppService>();

            var referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
            int trdQuantity = int.Parse(Console.ReadLine());
            List<TradeViewModel> trades = new List<TradeViewModel>();

            for (int i = 0; i < trdQuantity; i++)
            {
                var input = Console.ReadLine().Split(" ");

                var trade = new TradeViewModel
                {
                    Value = double.Parse(input[0]),
                    ClientSector = input[1],
                    NextPaymentDate = DateTime.ParseExact(input[2], "MM/dd/yyyy", null)
                };

                trades.Add(trade);
            }

            Console.WriteLine("\n");

            foreach (var item in trades)
            {
                Console.WriteLine(tradeAppService.ClassifyTrade(item, referenceDate));
            }
        }
    }
}
