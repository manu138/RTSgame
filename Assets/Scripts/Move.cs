using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : State
{

public Move(State state)
    {

    }
    public override void CompararVida(int healthCharacter, int healthEnemy)
    {
        throw new NotImplementedException();
    }
    public override void VerificarEnemigos(Transform player,LayerMask enemyLayer)
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(player.position, 1f, enemyLayer);
        if (colliders.Length > 0)
        {
            ChangeState();
        }
    }

    public override void ChangeState()
    {
        character.State = new Attack(this);
    }
  
}
