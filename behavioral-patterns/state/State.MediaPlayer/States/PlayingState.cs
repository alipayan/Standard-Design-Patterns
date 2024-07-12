namespace State.MediaPlayer.States;

public class PlayingState : State
{
    public PlayingState(Player player) : base(player) { }

    public override void ClickLock()
    {
        Player.ChangeState(new LockedState(Player));
    }

    public override void ClickPlay()
    {
        Player.StopPlayback();
        Player.ChangeState(new ReadyState(Player));
    }

    public override void ClickNext()
    {
        if (/* event.doubleclick */ false) // Placeholder for the actual double-click event check.
        {
            Player.NextSong();
        }
        else
        {
            Player.FastForward(5);
        }
    }

    public override void ClickPrevious()
    {
        if (/* event.doubleclick */ false) // Placeholder for the actual double-click event check.
        {
            Player.PreviousSong();
        }
        else
        {
            Player.Rewind(5);
        }
    }
}
