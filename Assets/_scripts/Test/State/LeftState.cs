using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class LeftState : JyState
    {
        public LeftState( ) : base("LeftState")
        {

        }

        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter LeftState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit LeftState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("LeftState DoTransition");
        }

    }
}
