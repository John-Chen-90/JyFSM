using JyFSM.FSM;

namespace JyFSM.Test
{
    public class Player
    {
        private JyStateMachine FSM;
        private UpState _up;
        private DownState _down;
        private LeftState _left;
        private RightState _right;
        private JumpState _jump;
        private AttackState _attack;
        private IdleState _idle;

        public string KeyBoard;

        public Player()
        {
            _idle = new IdleState();
            _up = new UpState();
            _attack = new AttackState();
            _jump = new JumpState();
            _down = new DownState();
            _left = new LeftState();
            _right = new RightState();

            // 添加在idle状态下的转换
            _idle.AddTransition(new IdleToAttack("IdleAttack", _idle, _attack, this));
            _idle.AddTransition(new IdleToDown("IdleDown", _idle, _down, this));
            _idle.AddTransition(new IdleToJump("IdleJump", _idle, _jump, this));
            _idle.AddTransition(new IdleToLeft("IdleLeft", _idle, _left, this));
            _idle.AddTransition(new IdleToRight("IdleRight", _idle, _right, this));
            _idle.AddTransition(new IdleToUp("IdleUp", _idle, _up, this));

            // 添加在Up状态下的转换
            _up.AddTransition(new UpToIdle("UpIdle", _up, _idle, this));
            _up.AddTransition(new UpToAttack("UpAttack", _up, _attack, this));
            _up.AddTransition(new UpToJump("UpJump", _up, _jump, this));
            _up.AddTransition(new UpToLeft("UpLeft", _up, _left, this));
            _up.AddTransition(new UpToRight("UpRight", _up, _right, this));

            // 添加在Attack状态下的转换
            _attack.AddTransition(new AttackToIdle("AttackIdle", _attack, _idle, this));

            // 添加在Jump状态下的转换
            _jump.AddTransition(new JumpToIdle("JumpIdle", _jump, _idle, this));

            // 添加在Down状态下的转换
            _down.AddTransition(new DownToIdle("DownIdle", _down, _idle, this));
            _down.AddTransition(new DownToUp("DownUp", _down, _up, this));

            // 添加在Left状态下的转换
            _left.AddTransition(new LeftToIdle("LeftIdle", _left, _idle, this));

            // 添加在Right状态下的转换
            _right.AddTransition(new RightToIdle("RightIdle", _right, _idle, this));

            FSM = new JyStateMachine("Player", _idle);
            FSM.AddState(_idle);
            FSM.AddState(_attack);
            FSM.AddState(_jump);
            FSM.AddState(_up);
            FSM.AddState(_down);
            FSM.AddState(_left);
            FSM.AddState(_right);

            //FSM.SetCurState(_idle);
        }


        public void Update(float t)
        {
            FSM.OnUpdate(t);
        }

    }
}
