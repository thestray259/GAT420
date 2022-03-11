using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealState : State
{
    public HealState(StateAgent owner, string name) : base(owner, name)
    {
    }

    public override void OnEnter()
    {
        owner.movement.Stop();
        owner.animator.SetTrigger("heal");
        owner.timer.value = 1;
        //owner.GetComponent<AgentDamage>().Damage();
        owner.GetComponent<AgentHeal>().Heal(); 
    }

    public override void OnExit()
    {
        
    }

    public override void OnUpdate()
    {
        
    }
}
