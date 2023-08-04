
using UnityEngine;

public class StateMachine : MonoBehaviour, IStateMachine
{
    public string Name { get; private set; }
    public IBaseState CurrentState { get; private set; }
    private IBaseState nextState;
    private IBaseState mainState;

    void Awake()
    {
        SetMainAsNextState();
    }
    void Update()
    {
        if (nextState != null) { SetState(nextState); }
        CurrentState?.FrameUpdate();
    }
    void FixedUpdate()
    {
        CurrentState?.PhysicsUpdate();
    }
    void LateUpdate()
    {
        CurrentState?.LateUpdate();
    }
    private void OnValidate()
    {
        if (mainState == null)
        {
            if (Name.Equals("Player"))
            {
               // *** mainState = new PlayerIdleState();
            }
        }
    }
    public void SetMainAsNextState()
    {
        nextState = mainState;
    }
    public void SetNextState(IBaseState nextState)
    {
        if (nextState != null)
        {
            this.nextState = nextState;
        }
    }
    private void SetState(IBaseState newState)
    {
        if (newState != null)
        {
            nextState = null;
            CurrentState?.ExitState();
            CurrentState = newState;
            CurrentState.EnterState(this);
        }
    }
}
