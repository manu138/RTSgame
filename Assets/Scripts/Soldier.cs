﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Soldier : MonoBehaviour
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

    
    public abstract void Move(float tiledistance);
    public abstract void Attack(int enemyHealth, int enemyDefense);
    public abstract void Stay();
  

}
