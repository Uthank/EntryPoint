using FiniteStateMachine;

namespace Structure
{
    public class GameBootstrapState : IState
    {
        private readonly StateMachine _stateMachine;

        public GameBootstrapState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            Services.Init();
            _stateMachine.Enter(new GameLoopState(_stateMachine));
        }

        public void Exit()
        {
        }
    }
}