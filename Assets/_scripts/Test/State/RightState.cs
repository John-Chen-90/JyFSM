using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class RightState : JyState
    {
        public RightState( ) : base("RightState")
        {

        }


        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter RightState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit RightState");
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);

        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("RightState DoTransition");
        }

    }
}
