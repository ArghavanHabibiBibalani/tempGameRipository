using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState 
{ 
    protected Enemy_Ai enemy;
    protected StateMachine stateMachine;
   

    public BaseState (Enemy_Ai enemy,StateMachine stateMachine)
    {
        this.enemy = enemy;
        this.stateMachine = stateMachine;
    }

    public virtual void EnterState() { }
    
    public virtual void ExitState() { }
    
    public virtual void FrameUpdate() { }
    
    public virtual void PhysicsUpdate() { }
    
    public virtual void AnimationTriggerEvent() { }



}
