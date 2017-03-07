using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace FlyWeight.Characters
{
    public class SoldierTypeTwo : Soldier
{
        public bool isTouching = false;
        public void Update()
        {
            if (isTouching == true)
            {
                
            }
        }
        public void OnTriggerEnter2D(Collider2D other)
        {
            Soldier enemy = other.GetComponent<Soldier>();
            isTouching = true;
            enemy.attack = enemyAttack;
            enemy.health = enemyHealth;
            enemy.defense = enemyDefense;
            enemy.team = enemyTeam;
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
