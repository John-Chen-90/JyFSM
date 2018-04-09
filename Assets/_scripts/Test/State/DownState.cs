using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class DownState : JyState
    {
        public DownState() : base("DownState")
        {

        }


        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter DownState");
            Debug.Log("Enter DownState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit DownState");
            Debug.Log("Enter DownState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("DownState DoTransition");
            Debug.Log("AttackState DoTransition");
        }

    }
}
