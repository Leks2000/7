using System;
using System.Collections.Generic;
using System.Text;

namespace ПР7_Николаев
{
    public abstract class Armament
    {
        private int atk;
        private int def;
        private int hp;


        public Armament() { }

        public Armament(int atk,int def,int hp)
        {
            this.ATK = atk;
            this.DEF = def;
            this.HP = hp;
        }

        public int ATK
        {
            get => atk;
            set => atk = value;
        }

        public int DEF
        {
            get => def;
            set => def = value;
        }

        public int HP
        {
            get => hp;
            set => hp = value;
        }


        public virtual void Show()
        {
            Console.WriteLine($"Атака = {ATK}\r\nЗащита = {DEF}\r\nЖизнь = {HP} ед.");
        }

    }
}