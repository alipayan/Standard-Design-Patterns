namespace State.MediaPlayer.States;

public class ReadyState : State
{
    public ReadyState(Player player) : base(player) { }

    public override void ClickLock()
    {
        Player.ChangeState(new LockedState(Player));
    }

    public override void ClickPlay()
    {
        Player.StartPlayback();
        Player.ChangeState(new PlayingState(Player));
    }

    public override void ClickNext()
    {
        Player.NextSong();
    }

    public override void ClickPrevious()
    {
        Player.PreviousSong();
    }
}
