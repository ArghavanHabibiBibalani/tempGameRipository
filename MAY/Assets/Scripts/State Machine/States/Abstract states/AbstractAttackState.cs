using UnityEngine;

public abstract class AbstractAttackState : IBaseState, IAnimatable
{
    
    public virtual void EnterState()
    {

    }

    public virtual void ExitState()
    {

    }

    public virtual void FrameUpdate()
    {
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void AnimationTriggerEvent()
    {
    }

}
