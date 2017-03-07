using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyWeight.Characters
{

    public class SoldierTypeOne : Soldier
    {

        public static SoldierTypeOne Instance { get; private set; }

        public int soldierTypeOnehealth { get; private set; }


        void Awake()
        {
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



        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "A")
                coll.gameObject.SendMessage("ApplyDamage", 10);

        }

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