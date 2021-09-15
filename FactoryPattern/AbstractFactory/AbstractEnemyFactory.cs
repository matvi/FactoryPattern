using FactoryPattern.Common.Enum;
using FactoryPattern.Factory;
using FactoryPattern.Interface;

namespace FactoryPattern.AbstractFactory
{
    public class AbstractEnemyFactory : IAbstractEnemyFactory
    {
        public IEnemyFactory GetEnemyFactoryByUserType(UserType userType)
        {
            switch (userType)
            {
                case UserType.AdvanceUser: return new HardEnemyFactory();
                case UserType.MiddleUser : return new KoopaFactory();
                case UserType.NewUser : return new EasyEnemyFactory();
                default: return new EasyEnemyFactory();
            }
        }
    }
}