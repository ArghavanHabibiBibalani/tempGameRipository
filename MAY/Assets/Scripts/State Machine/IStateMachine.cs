public interface IStateMachine 
{
    public IBaseState CurrentState { get; set; }

    public void ChangeState(IBaseState newState);
}
