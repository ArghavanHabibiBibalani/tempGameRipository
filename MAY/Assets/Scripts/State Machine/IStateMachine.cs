public interface IStateMachine 
{
    public string Name { get; }  
    public IBaseState CurrentState { get; }

    public void SetNextState(IBaseState nextState);
    public void SetMainAsNextState();
}
