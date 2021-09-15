using FactoryPattern.Common.Enum;

namespace FactoryPattern.Interface
{
    public interface IBatterService
    {
        void StartAttack(UserType userType);
    }
}