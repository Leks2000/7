using System;
using System.Collections.Generic;
using System.Text;

namespace ПР7_Николаев
{
    public class Shooting : Armament
    {
        private int cost;
        private Model model_shot;   

        public Shooting() 
        {
            Cost = 0;
            model_shot = Model.None;
        }

        public Shooting(int atk,int def,int hp,int cost,Model model)
            :base(atk,def,hp)
        {
            model_shot = model;
            this.Cost = cost;
        }

        public int Cost
        {
            get => cost;
            set => cost = value;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Стрелок взял с собой {model_shot}, который стоит {Cost:C2}\n");
        }


    }
}