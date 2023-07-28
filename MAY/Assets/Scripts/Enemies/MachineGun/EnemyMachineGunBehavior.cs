using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMachineGunBehavior : MonoBehaviour, IHasIdle, IHasAttack , IEntityBihavior
{

    public AbstractIdleState IdleState { get; set; }
    public AbstractAttackState AttackState { get; set; }

    public StateMachine _stateMachine { get; set; }

    public GameObject bullet;
    public Transform bulletPos;

    public float timer;
    public GameObject player;
    float distanceFromPlayer;
    public bool flag = true;


     void Awake() 
     {
        _stateMachine = new StateMachine();
        IdleState = new IdelStateMachineGun();
        AttackState = new AttackStateMachineGun(this);
        
        _stateMachine.CurrentState = IdleState;  

        player = GameObject.FindGameObjectWithTag("Player");

     }


    void Update()
    {
        _stateMachine.CurrentState.FrameUpdate();


        distanceFromPlayer = Vector2.Distance(transform.position, player.transform.position);

   
        if (distanceFromPlayer < 10 && _stateMachine.CurrentState != AttackState)
        {
            _stateMachine.ChangeState(AttackState);
            flag= true;
            
        }
        else if(distanceFromPlayer >= 10 && flag == true && _stateMachine.CurrentState != IdleState)
        {
            _stateMachine.ChangeState(IdleState);
            flag= false;
        }


       

    }

    public void shot()
    {
        Instantiate(bullet,transform.position, Quaternion.identity);
    }


}
