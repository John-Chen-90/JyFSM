﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFSM.FSM
{
    public interface IStateMachine
    {
        IState CurState { get; }
        IState DefaultState { get; }
        void AddState(IState state);
        void RemoveState(IState state);
        void SetCurState(IState state);
        IState GetStateWithTag(string tag);
        IState GetStateWithName(string name);
        Dictionary<string, IState> States { get; }        
    }
}
