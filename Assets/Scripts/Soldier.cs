using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public int health;
    public int defense;
    public int attack;
    public string team;

        public Soldier (int _health,int _defense,int _attack,string _team)
        {
        _team = this.team;
        _health = this.health;
        _defense = this.defense;
        _attack = this.attack;
        }
    
    public void Attack(int enemyAttack)
    {
        health=health-enemyAttack;
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
