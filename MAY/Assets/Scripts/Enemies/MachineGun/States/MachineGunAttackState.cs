using UnityEngine;


public class MachineGunAttackState : AbstractAttackState
{
    public EnemyMachineGunBehavior machineGun;
    public MachineGunAttackState(EnemyMachineGunBehavior machineGun) 
    {
        this.machineGun = machineGun;
    }

    public override void EnterState()
    {
        base.EnterState();
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();
        machineGun.timer += Time.deltaTime;
        if (machineGun.timer > 0.5)
        {
            machineGun.timer = 0;
            machineGun.shot();
        }
    }

    
}
