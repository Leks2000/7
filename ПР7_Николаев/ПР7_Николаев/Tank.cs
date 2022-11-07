using System;
using System.Collections.Generic;
using System.Text;

namespace ПР7_Николаев
{
    public class Tank : Armament
    {
        private string col;
        private Model_Tank model_tank;

        public Tank()
        {
            Col = "Неизвестно";
            model_tank = Model_Tank.None;
        }

        public Tank(int atk, int def, int hp, string col, Model_Tank model)
            : base(atk, def, hp)
        {
            this.Col = col;
            this.model_tank = model;
        }

        public string Col
        {
            get => col;
            set => col = value;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Танк моделью - {model_tank}, который был цвета: {Col}\n");
        }

    }
}