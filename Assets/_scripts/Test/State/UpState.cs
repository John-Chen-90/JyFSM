using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class UpState : JyState
    {
        public UpState( ) : base("UpState")
        {

        }

        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter UpState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit UpState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("UpState DoTransition");
        }

    }
}
