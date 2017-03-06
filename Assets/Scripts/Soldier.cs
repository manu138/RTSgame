using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
   static int health;
    static int defense;
  static int attack;
   static string team;



    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
    Soldier enemy=other.GetComponent<Soldier>();

    }
    public void Attack(int enemyDefense, int enemyHealth)
    {
        enemyHealth = enemyHealth-(enemyDefense - attack);
    }
    
    public void Move(float tiledistance)
    {
        tiledistance = 2.34f;
        transform.position = new Vector2(transform.position.x + tiledistance, 0);
    }

    public void Stay()
    {

    }


}
