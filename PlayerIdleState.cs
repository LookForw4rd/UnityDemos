using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        rb.linearVelocity = new Vector2(0, 0);
    }

    public override void Update()
    {
        base.Update();
        
        /*
        if(xInput != 0)
            stateMachine.ChangeState(player.moveState);
        */
        
        //myself code 
        if(xInput != 0 && (!player.IsWallDetected() || (player.IsWallDetected() && xInput != player.facingDir)))
            stateMachine.ChangeState(player.moveState);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
