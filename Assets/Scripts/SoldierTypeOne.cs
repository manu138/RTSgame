using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyWeight.Characters
{

    public class SoldierTypeOne : Soldier
{
        public int Gethealth()
        {
            return health;
        }
    public override void Attack(int enemyHealth, int enemyDefense)
    {
            enemyHealth = enemyHealth - (enemyDefense - attack);
        }
    public override void Move(float tiledistance)
    {
            transform.position = new Vector2(transform.position.x + tiledistance, 0);
        }
    public override void Stay()
    {
        throw new NotImplementedException();
    }
}
}