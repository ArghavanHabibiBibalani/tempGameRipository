using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine 
{
    public BaseState CurrentState { get; set; }

    public void ChangeState(BaseState newState)
    {
        CurrentState?.ExitState();
        CurrentState = newState;    
        CurrentState.EnterState();
    }
}
