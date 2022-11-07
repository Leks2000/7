using System;
using System.Text;

namespace ПР7_Николаев
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Armament[] mas = new Armament[9];

            mas[0] = new Shooting(10, 5, 15, 200, Model.AK_47);
            mas[1] = new Shooting(40, 2, 2, 2000, Model.Grenade);
            mas[2] = new Tank(60, 60, 60, "Черный", Model_Tank.T_34);
            mas[3] = new Tank(100, 60, 30, "Белый в полоску", Model_Tank.TKP_342);
            mas[4] = new Airplane(40, 10, 40, 100, Model_Air.Gidra);
            mas[5] = new Airplane(40, 10, 40, 300, Model_Air.Ex_5783);
            mas[6] = new Shooting();
            mas[7] = new Tank();
            mas[8] = new Airplane();
            
            for(int i =0; i< mas.Length; i++)
            {
                 Console.WriteLine($"**** {mas[i].GetType().Name}");
                 mas[i].Show();
            }

        }
    }
}
