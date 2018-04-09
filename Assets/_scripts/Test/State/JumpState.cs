using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class JumpState : JyState
    {
        public JumpState() : base("JumpState")
        {

        }


        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter JumpState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit JumpState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("JumpState DoTransition");
        }

    }
}
