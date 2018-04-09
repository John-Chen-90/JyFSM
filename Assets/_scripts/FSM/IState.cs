using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFSM.FSM
{
    public delegate void VoidStateDelegate();
    public delegate void VoidStateDelegateState(IState state);
    public delegate void VoidStateDelegateFloat(float f);

    public interface IState
    {
        float Timer { get; }
        string Name { get; }
        string Tag { get; set; }
        void OnEnter(IState prev);
        void OnExit(IState next);
        void OnUpdate(float deltaTime);
        List<ITransition> Transitions { get; }
        void AddTransition(ITransition transition);
        IStateMachine Parent { get; }
        void SetStateMachine(IStateMachine stateMachine);
    }
}
