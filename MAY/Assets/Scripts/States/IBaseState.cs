
public interface IBaseState
{
    public abstract void EnterState();

    public abstract void ExitState();

    public abstract void FrameUpdate();

    public abstract void PhysicsUpdate();
}
