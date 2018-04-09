using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFSM.FSM
{
    public interface ITransition
    {
        string Name { get; }
        IState FromState { get; }
        IState ToState { get; }
        bool OnCheck();
        bool OnCompleteCallBack();
    }
}
