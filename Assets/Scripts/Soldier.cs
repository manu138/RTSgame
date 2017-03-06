using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
   public int health;
   public int defense;
public int attack;
  public string team;
    public float tile;

    public int enemyHealth;
    public int enemyDefense;
    public int enemyAttack;
    public string enemyTeam;

    void Update()
    {
        
    }
    void Start()
    {
        Move(tile);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Soldier enemy=other.GetComponent<Soldier>();
        enemy.attack = enemyAttack;
        enemy.health = enemyHealth;
        enemy.defense = enemyDefense;
        enemy.team = enemyTeam;
    }
    public void Attack()
    {
        enemyHealth = enemyHealth-(enemyDefense - attack);
    }
    
    public void Move(float tiledistance)
    {
      
        transform.position = new Vector2(transform.position.x + tiledistance, 0);
    }

    public void Stay()
    {

    }


}
