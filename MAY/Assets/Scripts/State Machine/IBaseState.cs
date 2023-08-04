public interface IBaseState
{
    public abstract void EnterState();

    public abstract void ExitState();

    public abstract void Update();

    public abstract void FixedUpdate();

    public virtual void LateUpdate();

    public static viod Destroy(UnityEngine.Object object);
}
