namespace Jogo_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string type, int hpMax, int mpMax)
        {
            this.name = name;
            this.level = level;
            this.type = $"{type} Knight";
            this.hp = hpMax;
            this.hpMax = hpMax;
            this.mp = mpMax;
            this.mpMax = mpMax;
        }
        public override string Attack()
        {
            return "Atacou com a Espada";
        }
        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} Lançou golpe super efetivo com bonus de: {bonus}";
            }

            return $"{this.name} Lançou golpe com força fraca com bonus de: {bonus}";
        }
    }
}