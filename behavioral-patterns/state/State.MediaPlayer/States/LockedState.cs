namespace State.MediaPlayer.States;

public class LockedState : State
{
    public LockedState(Player player) : base(player) { }

    // When you unlock a locked player, it may assume one of two states.
    public override void ClickLock()
    {
        if (Player.)
            Player.ChangeState(new PlayingState(Player));
        else
            Player.ChangeState(new ReadyState(Player));
    }

    public override void ClickPlay()
    {
        // Locked, so do nothing.
    }

    public override void ClickNext()
    {
        // Locked, so do nothing.
    }

    public override void ClickPrevious()
    {
        // Locked, so do nothing.
    }
}
