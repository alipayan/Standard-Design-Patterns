using State.MediaPlayer.States;

namespace State.MediaPlayer;

public class Player
{
    private State _state;
    private PlayerUserInterface _ui;
    private int _volume;
    private string[] _playlist;
    private string _currentSong;

    public Player()
    {
        _state = new ReadyState(this);

        // Context delegates handling user input to a state object. 
        // Naturally, the outcome depends on what state is currently active,
        // since each state can handle the input differently.
        _ui = new PlayerUserInterface();
        _ui.LockButton.Click += (sender, e) => ClickLock();
        _ui.PlayButton.Click += (sender, e) => ClickPlay();
        _ui.NextButton.Click += (sender, e) => ClickNext();
        _ui.PrevButton.Click += (sender, e) => ClickPrevious();
    }

    // Other objects must be able to switch the audio player's active state.
    public void ChangeState(State state)
    {
        _state = state;
    }

    // UI methods delegate execution to the active state.
    public void ClickLock()
    {
        _state.ClickLock();
    }

    public void ClickPlay()
    {
        _state.ClickPlay();
    }

    public void ClickNext()
    {
        _state.ClickNext();
    }

    public void ClickPrevious()
    {
        _state.ClickPrevious();
    }

    // A state may call some service methods on the context.
    public void StartPlayback()
    {
        // ...
    }

    public void StopPlayback()
    {
        // ...
    }

    public void NextSong()
    {
        // ...
    }

    public void PreviousSong()
    {
        // ...
    }

    public void FastForward(int time)
    {
        // ...
    }

    public void Rewind(int time)
    {
        // ...
    }
}
