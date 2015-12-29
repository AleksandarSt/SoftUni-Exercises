using Battleships.Interfaces;
namespace Battleships.Ships
{
    public class BattleShip:Ship,IAttack
    {
        public BattleShip(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
        }

        public virtual string Attack(Ship target)
        {
            return string.Empty;
        }

        protected virtual void DestroyTarget(Ship target)
        {
            target.IsDestroyed = true;
        }
        
    }
}
