namespace State.MediaPlayer;

public abstract class State
{
    protected Player Player;

    // Context passes itself through the state constructor. This
    // may help a state fetch some useful context data if it's needed.
    protected State(Player player)
    {
        Player = player;
    }

    public abstract void ClickLock();
    public abstract void ClickPlay();
    public abstract void ClickNext();
    public abstract void ClickPrevious();
}
