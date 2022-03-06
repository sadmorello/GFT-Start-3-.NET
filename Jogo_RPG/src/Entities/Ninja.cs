namespace Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string type, int hpMax, int mpMax)
        {
            this.name = name;
            this.level = level;
            this.type = $"{type} Ninja";
            this.hp = hpMax;
            this.hpMax = hpMax;
            this.mp = mpMax;
            this.mpMax = mpMax;
        }
        public override string Attack()
        {
            return "Atacou com shuriken";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} Lançou shuriken super efetiva com bonus de: {bonus}";
            }

            return $"{this.name} Lançou shuriken com força fraca com bonus de: {bonus}";
        }
    }
}