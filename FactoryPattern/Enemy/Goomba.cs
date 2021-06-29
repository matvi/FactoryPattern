using System;
using FactoryPattern.Interface;

namespace FactoryPattern.Enemy
{
    public class Goomba: IEnemy

    {
        public void Attack()
        {
            Console.WriteLine("Goomba attacks");
        }
    }
}