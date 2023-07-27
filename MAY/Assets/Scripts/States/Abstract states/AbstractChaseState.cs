

public class AbstractChaseState : IBaseState, IAnimatable
{
    // Default behavior for child states in case they don't override these methods
    public virtual void EnterState()
    {
        throw new System.NotImplementedException();
    }

    public virtual void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public virtual void FrameUpdate()
    {
        throw new System.NotImplementedException();
    }

    public virtual void PhysicsUpdate()
    {
        throw new System.NotImplementedException();
    }
    public virtual void AnimationTriggerEvent()
    {
        throw new System.NotImplementedException();
    }
}
