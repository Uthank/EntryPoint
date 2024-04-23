namespace FiniteStateMachine
{
    public class StateMachine
    {
        private IState currentState;
        public void Enter(IState state)
        {
            currentState?.Exit();
            currentState = state;
            currentState.Enter();
        }
    }
}