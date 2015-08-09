using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractice.PatternClasses.Patterns.AbstractFactory.Classes
{
    /// <summary>
    /// Our Dungeon Template.
    /// All classes in the same file to make it easier to follow the pattern
    /// </summary>
    abstract class DungeonFactory
    {
        public abstract Monster CreateMonster();
        public abstract Hero CreateHero();
    }

    #region abstracts
    abstract class Monster
    {
        public abstract void Attack(Hero H);
    }



    abstract class Hero
    {
        public abstract void Attack(Monster m);
    }

    class Wizard : Hero
    {
        public override void Attack(Monster m)
        {
            Console.WriteLine(this.GetType().Name + " attacks " + m.GetType().Name + " It's super effective!");
        }
    }
    #endregion

    #region concretes

    class UndeadDungeonFactory : DungeonFactory
    {
        public override Hero CreateHero()
        {
            return new Wizard();
        }

        public override Monster CreateMonster()
        {
            return new Zombie();
        }
    }

    class GoblinDungeonFactory : DungeonFactory
    {
        public override Hero CreateHero()
        {
            return new Warrior();
        }

        public override Monster CreateMonster()
        {
            return new Goblin();
        }
    }

    class Warrior : Hero
    {
        public override void Attack(Monster m)
        {
            Console.WriteLine(this.GetType().Name + " attacks " + m.GetType().Name + " It's super effective!");
        }
    }

    class Goblin : Monster
    {
        public override void Attack(Hero H)
        {
            Console.WriteLine(this.GetType().Name + " attacks " + H.GetType().Name + " It's super effective!");
        }
    }

    class Zombie : Monster
    {
        public override void Attack(Hero H)
        {
            Console.WriteLine(this.GetType().Name + " attacks " + H.GetType().Name + " It's super effective!");
        }
    }
    #endregion


    class DungeonMaster { 

        private Hero _hero;
        private Monster _monster;

        public DungeonMaster(DungeonFactory factory)
        {
            _hero = factory.CreateHero();
            _monster = factory.CreateMonster();
        }

        public void RunAttacks()
        {
            _hero.Attack(_monster);
            _monster.Attack(_hero);
        }
    }


}
