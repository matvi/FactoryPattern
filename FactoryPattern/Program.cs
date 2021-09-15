using System;
using FactoryPattern.AbstractFactory;
using FactoryPattern.Common.Enum;
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
                .AddScoped<IAbstractEnemyFactory, AbstractEnemyFactory>()
                .BuildServiceProvider();

            var userType = GetUserTypeByLevel(100);
            var battleService = serviceProvider.GetService<IBatterService>();
            var battleController = new BattleController(battleService);
            battleController.StartBattle(userType);
            
        }

        static UserType GetUserTypeByLevel(int level)
        {
            return UserType.AdvanceUser;
        }
    }
}