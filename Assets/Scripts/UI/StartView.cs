using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class StartView : AbstractView
{
    [SerializeField] private Button playButton, exitButton;
    [SerializeField] private Toggle soundToggle, musicToggle;

    public UnityEvent OnPlay { get; } = new UnityEvent();
    public UnityEvent<bool> OnSound { get; } = new UnityEvent<bool>();
    public UnityEvent<bool> OnMusic { get; } = new UnityEvent<bool>();

    public override void Init()
    {
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        exitButton.onClick.AddListener(ExitButtonClicked);
        playButton.onClick.AddListener(PlayButtonClicked);
        soundToggle.onValueChanged.AddListener(OnSoundToggleClicked);
        musicToggle.onValueChanged.AddListener(OnMusicToggleClicked);
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        exitButton.onClick?.RemoveListener(ExitButtonClicked);
        playButton?.onClick?.RemoveListener(PlayButtonClicked);
        soundToggle.onValueChanged?.RemoveListener(OnSoundToggleClicked);
        musicToggle.onValueChanged?.RemoveListener(OnMusicToggleClicked);
    }
    private void ExitButtonClicked()
    {
        Application.Quit();
    }
    private void PlayButtonClicked()
    {
        OnPlay?.Invoke();
    }
    private void OnSoundToggleClicked(bool value)
    {
        OnSound?.Invoke(value);
    }
    private void OnMusicToggleClicked(bool value)
    {        
        OnMusic?.Invoke(value);
    }
}