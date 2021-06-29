using System;
using FactoryPattern.Interface;

namespace FactoryPattern.Enemy
{
    public class Koopa: IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Koopa attacks");
        }
    }
}