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
            ChangeState();
    }
    public override void VerificarEnemigos(Transform player, LayerMask enemylayer)
    {
       
    }
    public void Atacar(int healthEnemy)
    {
        healthEnemy -= healthEnemy;
    }
    public override void ChangeState()
    {
        character.State = new StayStill(this);
    }

}
