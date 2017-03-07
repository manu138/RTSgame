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
   

        public static SoldierTypeTwo Instance { get; private set; }

        public int soldierTypeTwohealth { get; private set; }

        public void Update()
        {
           
        
            if (SoldierTypeOne.Instance.turn==1)
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
            if (isTouching == false)
            {
                Move(2.34f);
            }
            }
        }
        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag == "B")
                isTouching = true;
              

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
        void Awake()
        {
            soldierTypeTwohealth = health;
            if (Instance)
            {
                DestroyImmediate(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
