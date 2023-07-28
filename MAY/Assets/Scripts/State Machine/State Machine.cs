using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : IStateMachine
{
    public IBaseState CurrentState { get;  set; }

    public void ChangeState(IBaseState newState)
    {
        CurrentState?.ExitState();
        CurrentState = newState;
        CurrentState.EnterState();
    }

}
