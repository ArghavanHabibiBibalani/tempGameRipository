using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBehavior : IEntityBihavior
{
    /// <summary>
    /// THIS CLASS CONTAINS STATE MACHINE AND SOME STATE STUFFS FOR ALL OF THE ENTITIES.
    /// </summary>

    public StateMachine _stateMachine;

    private void Awake()
    {
        _stateMachine = new StateMachine(); 
    }

    void Update()
    {
        _stateMachine.CurrentState.FrameUpdate();
    }

    private void FixedUpdate()
    {
        _stateMachine.CurrentState.PhysicsUpdate();

    }
}
