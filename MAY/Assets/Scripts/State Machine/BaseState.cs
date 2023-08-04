using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState : IBaseState
{
    protected float Time { get; set; }
    protected float FixedTime { get; set; }
    protected float LateTime { get; set; }

    public StateMachine StateMachine;

    public virtual void EnterState(StateMachine stateMachine)
    {
        StateMachine = stateMachine;
    }

    public virtual void ExitState()
    {

    }

    public virtual void Update()
    {
        Time += Time.deltaTime;
    }

    public virtual void FixedUpdate()
    {
        FixedTime += Time.deltaTime;
    }

    public virtual void LateUpdate()
    {
        LateTime += Time.deltaTime;
    }

    public static viod Destroy(UnityEngine.Object object)
    {
        UnityEngine.Object.Destroy(object);
    }

    protected E GetComponent<E>() where E : Component
    {
        return StateMachine.GetComponent<E>();
    }

    protected Component GetComponent<>(System.Type type)
    {
        return StateMachine.GetComponent(type);
    }

    protected Component GetComponent(string type) 
    { 
        return StateMachine.GetComponent(type); 
    }


}
