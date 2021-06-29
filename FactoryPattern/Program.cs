using System;
using FactoryPattern.Controller;
using FactoryPattern.Factory;
using FactoryPattern.Interface;
using FactoryPattern.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IBatterService, BattleService>()
                .AddScoped<IEnemyFactory, KoopaFactory>()
                .AddScoped<IEnemyFactory, HardEnemyFactory>()
                .BuildServiceProvider();

             var battleService = serviceProvider.GetService<IBatterService>();
             var battleController = new BattleController(battleService);
            battleController.StartBattle();
            
        }
    }
}