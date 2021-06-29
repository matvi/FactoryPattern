using FactoryPattern.Interface;

namespace FactoryPattern.Services
{
    public class BattleService : IBatterService
    {
        private readonly IEnemyFactory _enemyFactory;

        public BattleService(IEnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
        }
        
        public void StartAttack()
        {
            var enemy = _enemyFactory.CreateEnemy();
            enemy.Attack();
        }
    }
}