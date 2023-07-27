using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// REMOVE OR UNCOMMENT THE COMMENTS WHEN COMBINING
public class MachineGun : MonoBehaviour, /*IHasStateMachine,*/ IHasIdle
{
    
    //public IStateMachine StateMachine => throw new System.NotImplementedException();

    public AbstractIdleState IdleState => throw new System.NotImplementedException();

}
