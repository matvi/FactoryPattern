using FactoryPattern.Common.Enum;
using FactoryPattern.Interface;

namespace FactoryPattern.AbstractFactory
{
    public interface IAbstractEnemyFactory
    {
        IEnemyFactory GetEnemyFactoryByUserType(UserType userType);
    }
}