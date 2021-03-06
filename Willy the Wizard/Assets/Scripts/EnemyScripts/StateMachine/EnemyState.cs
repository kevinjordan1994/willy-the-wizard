using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState
{
    protected EnemyFiniteStateMachine stateMachine;
    protected Enemy enemy;
    protected Core core;

    protected float startTime;
    protected string animBoolName;

    public EnemyState(Enemy enemy, EnemyFiniteStateMachine stateMachine, string animBoolName)
    {
        this.enemy = enemy;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
        core = enemy.Core;
    }

    public virtual void Enter()
    {
        startTime = Time.time;
        enemy.EAnimator.SetBool(animBoolName, true);
        DoChecks();
    }

    public virtual void Exit()
    {
        enemy.EAnimator.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks()
    {

    }
}
