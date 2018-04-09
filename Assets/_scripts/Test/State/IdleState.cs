using System;
using JyFSM.FSM;
using UnityEngine;

namespace JyFSM.Test
{
    public class IdleState : JyState
    {
        public IdleState() : base("IdleState")
        {

        }


        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            Debug.Log("Enter IdleState");
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            Debug.Log("Exit IdleState");
        }

        int i = 0;
        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);
            Debug.Log(this._transitions.Count.ToString());

            i += 1;
        }

        protected override void DoTransition(ITransition transition)
        {
            base.DoTransition(transition);

            Debug.Log("IdleState DoTransition");
        }

    }
}
