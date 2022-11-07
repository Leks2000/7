using System;
using System.Collections.Generic;
using System.Text;

namespace ПР7_Николаев
{
    public class Airplane : Armament
    {
        private int speed;
        private Model_Air model_air;

        public Airplane()
        {
            speed = 0;
            model_air = Model_Air.None;
        }

        public Airplane(int atk,int def,int hp,int speed,Model_Air model)
            :base(atk,def,hp)
        {
            this.model_air = model;
            this.speed = speed;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Самолет {model_air}, который летит со скоростью {Speed}\n");
        }

    }
}