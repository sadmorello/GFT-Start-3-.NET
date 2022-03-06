namespace Jogo_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string type, int hpMax, int mpMax)
        {
            this.name = name;
            this.level = level;
            this.type = $"{type} Wizard";
            this.hp = hpMax;
            this.hpMax = hpMax;
            this.mp = mpMax;
            this.mpMax = mpMax;
        }
        public override string Attack()
        {
            return "Atacou com Magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} Lançou magia super efetiva com bonus de: {bonus}";
            }

            return $"{this.name} Lançou magia com força fraca com bonus de: {bonus}";
        }
    }
}