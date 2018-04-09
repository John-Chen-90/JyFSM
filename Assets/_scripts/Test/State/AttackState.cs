using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class AttackState : JyState
    {
        public AttackState() : base("AttackState")
        {

        }


        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter AttackState");
            Debug.Log("Enter AttackState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit AttackState");
            Debug.Log("Exit AttackState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("AttackState DoTransition");
            Debug.Log("AttackState DoTransition");
        }

    }
}
