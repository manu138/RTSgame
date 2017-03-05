using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class State 
{
    protected Character character;
    public int healthCharacter;
    public int healthEnemy;
    public int attack;
    public int defense;
    public String team;



    public Character Character
    {
        get { return character; }
        set { character = value; }
    }


    
    public abstract void VerificarEnemigos();
    public abstract void ChangeState();
    public abstract void CompararVida(int healthCharacter,int healthEnemy);
  

}
