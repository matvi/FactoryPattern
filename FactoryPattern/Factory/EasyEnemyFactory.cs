using System;
using FactoryPattern.Enemy;
using FactoryPattern.Interface;

namespace FactoryPattern.Factory
{
    public class EasyEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            var random = new Random();

            if (random.Next() < .50)
            {
                return new Goomba();
            }

            return new Koopa();
        }
    }
}