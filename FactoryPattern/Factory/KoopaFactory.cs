using FactoryPattern.Enemy;
using FactoryPattern.Interface;

namespace FactoryPattern.Factory
{
    public class KoopaFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Koopa();
        }
    }
}