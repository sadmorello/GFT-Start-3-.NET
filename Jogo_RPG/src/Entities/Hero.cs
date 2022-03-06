namespace Jogo_RPG.src.Entities
{
    public abstract class Hero
    {
        public string name = "";
        public int level;
        public string type = "";
        public int hp;
        public int hpMax;
        public int mp;
        public int mpMax;
        public virtual string Attack()
        {
            return "";
        }

        public override string ToString()
        {
            return @$"Name: {this.name}
        Level: {this.level} Type: {this.type}
        HP: {this.hp} / {this.hpMax}
        MP: {this.mp} / {this.mpMax}";
        }
    }
}