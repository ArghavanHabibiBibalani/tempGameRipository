using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ai : MonoBehaviour
{
    #region State Machine Variables

    public StateMachine stateMachine { get; set; }
    public IdelState idelState { get; set; }
    public AttackState attackState { get; set; }

    #endregion


    private void Awake()
    {
        stateMachine = new StateMachine();

        idelState = new IdelState(this,stateMachine);

        attackState = new AttackState(this,stateMachine);    
    }


    void Update()
    {
        stateMachine.CurrentState.FrameUpdate();
    }

    private void FixedUpdate()
    {
        stateMachine.CurrentState.PhysicsUpdate();
        
    }

}
