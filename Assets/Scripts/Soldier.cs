using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    public int health;
    public int defense;
    public int attack;
    public string team;

    public void Attack()
    {

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
