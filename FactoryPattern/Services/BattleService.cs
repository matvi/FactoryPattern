using FactoryPattern.AbstractFactory;
using FactoryPattern.Common.Enum;
using FactoryPattern.Interface;

namespace FactoryPattern.Services
{
    public class BattleService : IBatterService
    {
        private readonly IAbstractEnemyFactory _abstractEnemyFactory;

        public BattleService(IAbstractEnemyFactory abstractEnemyFactory)
        {
            _abstractEnemyFactory = abstractEnemyFactory;
        }
        
        public void StartAttack(UserType userType)
        {
            var enemyFactory = _abstractEnemyFactory.GetEnemyFactoryByUserType(userType);
            var enemy = enemyFactory.CreateEnemy();
            enemy.Attack();
        }
    }
}