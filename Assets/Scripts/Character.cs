using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Character : MonoBehaviour
{

  private State _state;
    public int _health;
    private int _attack;
    private int _defense;
    private string _team;

    public Character (int health,int attack,int defense,string team)
    {
        this._health = health;
        this._attack = attack;
        this._defense = defense;
        this._team = team;


      } 
    
    public State State
    {
        get { return _state; }
        set { _state = value; }
    }             
  
    public void VerificarEnemigos()
    {

    }

    public void CompararVida()
    {

    }

}
