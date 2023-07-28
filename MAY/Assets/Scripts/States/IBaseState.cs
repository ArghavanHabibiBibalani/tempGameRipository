
public interface IBaseState
{
    void ChangeState(BaseState newState);
    public abstract void EnterState();

    public abstract void ExitState();

    public abstract void FrameUpdate();

    public abstract void PhysicsUpdate();
}
