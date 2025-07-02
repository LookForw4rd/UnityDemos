public class EnemyStateMachine
{
    public EnemyState currentState;

    public void Initialize(EnemyState _startstate)
    {
        currentState = _startstate;
        currentState.Enter();
    }

    public void ChangeState(EnemyState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }
}
