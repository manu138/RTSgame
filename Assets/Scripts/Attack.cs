using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Attack : State
{
    public Attack(State state)
    {
        this.character = state.Character;
        this.healthCharacter = state.healthCharacter;
        this.healthEnemy = state.healthEnemy;
    }

    public override void CompararVida(int healthCharacter, int healthEnemy)
    {
        if (healthCharacter >= healthEnemy)
        {
            Atacar(healthEnemy);
        }
        else
            character.State = new StayStill(this);
    }
    public override void VerificarEnemigos()
    {
       
    }
    public void Atacar(int healthEnemy)
    {
        healthEnemy -= healthEnemy;
    }
}
