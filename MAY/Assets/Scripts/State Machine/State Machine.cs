using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : IStateMachine
{
    public BaseState CurrentState { get; set; }

    IBaseState IStateMachine.CurrentState => throw new System.NotImplementedException();

    public void ChangeState(BaseState newState)
    {
        CurrentState?.ExitState();
        CurrentState = newState;    
        CurrentState.EnterState();
    }

    public void ChangeState(IBaseState newState)
    {
        throw new System.NotImplementedException();
    }

    public void EnterState()
    {
        throw new System.NotImplementedException();
    }

    public void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public void FrameUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void PhysicsUpdate()
    {
        throw new System.NotImplementedException();
    }
}
