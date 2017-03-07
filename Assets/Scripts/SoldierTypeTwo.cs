using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace FlyWeight.Characters
{
    public class SoldierTypeTwo : Soldier
{
        public bool isTouching = false;
        public int enemyHealth;
        public int enemyDefense;
        public void Update()
        {
            if (isTouching == true)
            {
                SoldierTypeOne.Instance.health = enemyHealth;
                SoldierTypeOne.Instance.defense = enemyDefense;
                if (enemyHealth > health)
                {
                    Move(2.34f);
                    Stay();
                }
                else
                    Attack(enemyHealth, enemyDefense);
            }
          
        }
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "B")
                coll.gameObject.SendMessage("ApplyDamage", 10);

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
