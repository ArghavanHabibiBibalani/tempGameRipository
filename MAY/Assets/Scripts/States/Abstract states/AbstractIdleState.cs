

public abstract class AbstractIdleState : IBaseState, IAnimatable, IStateMachine
{
    public IBaseState CurrentState => throw new System.NotImplementedException();

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

    public void ChangeState(BaseState newState)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeState(IBaseState newState)
    {
        throw new System.NotImplementedException();
    }
}
