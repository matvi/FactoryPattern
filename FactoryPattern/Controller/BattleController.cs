using FactoryPattern.Common.Enum;
using FactoryPattern.Interface;

namespace FactoryPattern.Controller
{
    public class BattleController
    {
        private readonly IBatterService _batterService;

        public BattleController(IBatterService batterService)
        {
            _batterService = batterService;
        }

        public void StartBattle(UserType userType)
        {
            _batterService.StartAttack(userType);
        }
    }
}