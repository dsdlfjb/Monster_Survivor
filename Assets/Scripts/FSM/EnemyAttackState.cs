﻿using UnityEngine;

public class EnemyAttackState : EnemyState
{
    public override void Enter(Enemy target)
    {
        //Debug.Log("적이 공격합니다.");

        target.AttackToPlayer();
        // 공격후 다시 추격상태로 변경
        target.ChangeState(EEnemyState.Chase);
    }

    public override void Execute(Enemy target) { }

    public override void Exit(Enemy target) { }
}