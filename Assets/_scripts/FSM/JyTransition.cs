using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFSM.FSM
{
    public class JyTransition : ITransition
    {
        public JyTransition(string name, IState from, IState to)
        {
            _to = to;
            _from = from;
            _name = name;
        }

        public string Name { get { return _name; } }
        public IState ToState { get { return _to; } }
        public IState FromState { get { return _from; } }

        /// <summary>
        /// 检测能否转换
        /// </summary>
        /// <returns></returns>
        public virtual bool OnCheck()
        {
            return true;
        }

        /// <summary>
        /// 检测转换函数是否执行完毕
        /// </summary>
        /// <returns></returns>
        public virtual bool OnCompleteCallBack()
        {
            return true;
        }

        protected IState _from;
        protected IState _to;
        protected string _name;
    }
}
