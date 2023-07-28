using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateMachine : IBaseState
{
    public IBaseState CurrentState { get;}

    public void ChangeState(IBaseState newState);
}
