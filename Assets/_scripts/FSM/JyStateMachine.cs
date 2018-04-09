using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFSM.FSM
{
    public class JyStateMachine : JyState, IStateMachine
    {
        public IState CurState { get { return _curState; } }
        public IState DefaultState { get { return _defaultState; } }        
        public Dictionary<string, IState> States { get { return _states; } }

        public JyStateMachine(string name, IState defaultState) : base(name)
        {
            _states = new Dictionary<string, IState>();
            AddState(defaultState);
            _defaultState = defaultState;
            _curState = defaultState;
            _curState.OnEnter(null);
        }

        /// <summary>
        /// 添加状态
        /// </summary>
        /// <param name="state"></param>
        public void AddState(IState state)
        {
            if(!_states.ContainsKey(state.Name))
            {
                _states.Add(state.Name, state);
                state.SetStateMachine(this);
            }
            else
            {
                // log warining: 已有该 state 状态
            }
        }

        /// <summary>
        /// 获得状态
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IState GetStateWithName(string name)
        {
            return _states != null ? _states[name] : null;
        }

        /// <summary>
        /// 获得状态
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public IState GetStateWithTag(string tag)
        {
            foreach(var state in _states.Values)
            {
                if (state.Tag == tag)
                    return state;
            }
            return null;
        }

        /// <summary>
        /// 移除状态
        /// </summary>
        /// <param name="state"></param>
        public void RemoveState(IState state)
        {
            if (_states.ContainsKey(state.Name)) _states.Remove(state.Name);
            if (_defaultState == _curState && _curState == state)
            {
                _curState = _states.Count > 0 ? _states[_states.Keys.ToArray()[0]] : null;
                _defaultState = _curState;                
            }
            else if(_defaultState != _curState && _defaultState == state)
            {
                _defaultState = _curState;
            }
            else if(_curState != _defaultState && _curState == state)
            {
                _curState = _states.Count > 0 ? _states[_states.Keys.ToArray()[0]] : null;
            }
        }

        /// <summary>
        /// 设置当前状态
        /// </summary>
        /// <param name="state"></param>
        public void SetCurState(IState state)
        {
            if(state == null)
            {
                // log warining : 传入的 state 为空！
                return;
            }

            _curState = state;
        }

        public override void OnEnter(IState prev)
        {
            base.OnEnter(prev);
            _curState.OnEnter(prev);
        }

        public override void OnExit(IState next)
        {
            base.OnExit(next);
            _curState.OnExit(next);
        }

        public override void OnUpdate(float deltaTime)
        {
            base.OnUpdate(deltaTime);
            _curState.OnUpdate(deltaTime);
        }

        private IState _curState;
        private IState _defaultState;
        private Dictionary<string, IState> _states;
    }
}
