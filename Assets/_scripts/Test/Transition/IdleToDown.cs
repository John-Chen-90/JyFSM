using JyFSM.FSM;


namespace JyFSM.Test
{
    public class IdleToDown : JyTransition
    {
        public IdleToDown(string name, IState from, IState to, Player player) : base(name, from, to)
        {
            _player = player;
        }

        public override bool OnCheck()
        {
            if(_player.KeyBoard == "S")
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
