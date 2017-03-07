using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyWeight.Characters
{

    public class SoldierTypeOne : Soldier
    {
        public bool isTouching = false;
        public int enemyHealth;
        public int enemyDefense;
        public  int turn;
        public static SoldierTypeOne Instance { get; private set; }

        public int soldierTypeOnehealth { get; private set; }

        public void Update()
        {
          
            if(Input.GetButtonDown("Jump"))
            {
                turn=1;
            }
            if(turn==0)
            { 
            if (isTouching == true)
            {
                SoldierTypeTwo.Instance.health = enemyHealth;
                SoldierTypeTwo.Instance.defense = enemyDefense;
                if (enemyHealth > health)
                {
                    Move(-2.34f);
                    Stay();
                }
                else
                    Attack(enemyHealth, enemyDefense);
            }
            if(isTouching==false)
            {
                Move(-2.34f);
            }
            }
        }
        void Awake()
        {
            soldierTypeOnehealth = health;
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
                isTouching = true;
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