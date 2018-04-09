using JyFSM.FSM;


namespace JyFSM.Test
{
    public class UpToIdle : JyTransition
    {
        public UpToIdle(string name, IState from, IState to, Player player) : base(name, from, to)
        {
            _player = player;
        }

        public override bool OnCheck()
        {
            if(_player.KeyBoard == "")
                return true;

            return false;
        }

        public override bool OnCompleteCallBack()
        {
            return true;
        }

        protected Player _player;
    }
}
