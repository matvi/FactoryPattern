using FactoryPattern.Enemy;
using FactoryPattern.Interface;

namespace FactoryPattern.Factory
{
    public class HardEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Bowser();
        }
    }
}