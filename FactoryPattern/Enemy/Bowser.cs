using System;
using FactoryPattern.Interface;

namespace FactoryPattern.Enemy
{
    public class Bowser : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Browser attacks");
        }
    }
}