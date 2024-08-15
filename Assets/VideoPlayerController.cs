using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems; // Add this for event handling
using TMPro;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton;
    public Button pauseButton;
    public Button stopButton;
    public Slider volumeSlider;
    public Slider progressBar;
    public Button fullScreenButton; // Add this line
    public Button muteButton; // Add this line
    
    private bool isMuted = false; // Track mute state
    private bool isDragging = false;
    private bool isFullScreen = false; // Track full-screen state

    void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
        pauseButton.onClick.AddListener(PauseVideo);
        stopButton.onClick.AddListener(StopVideo);
        volumeSlider.onValueChanged.AddListener(SetVolume);
        progressBar.onValueChanged.AddListener(SeekVideo);
        fullScreenButton.onClick.AddListener(ToggleFullScreen); // Add this line
        muteButton.onClick.AddListener(ToggleMute); // Add this line
    }

    void Update()
    {
        if (!isDragging && videoPlayer.isPlaying)
        {
            progressBar.value = (float)(videoPlayer.time / videoPlayer.length);
        }
    }

    void PlayVideo()
    {
        videoPlayer.Play();
    }

    void PauseVideo()
    {
        videoPlayer.Pause();
    }

    void StopVideo()
    {
        videoPlayer.Stop();
    }

    void SetVolume(float volume)
    {
        videoPlayer.SetDirectAudioVolume(0, volume);
    }

    void SeekVideo(float value)
    {
        if (isDragging)
        {
            videoPlayer.time = videoPlayer.length * value;
        }
    }

    public void OnDragStart()
    {
        isDragging = true;
    }

    public void OnDragEnd()
    {
        isDragging = false;
    }

    void ToggleFullScreen()
    {
        isFullScreen = !isFullScreen;
        if (isFullScreen)
        {
            // Switch to full-screen mode and set the full-screen mode to FullScreenWindow
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            Debug.Log("Switched to full-screen mode: " + Screen.currentResolution.width + "x" + Screen.currentResolution.height);
        }
        else
        {
            // Switch to windowed mode with a small resolution and set full-screen mode to Windowed
            Screen.fullScreenMode = FullScreenMode.Windowed;
            Screen.SetResolution(640, 480, false);
            Debug.Log("Switched to windowed mode: 640x480");
        }
    }
    void ToggleMute()
    {
        isMuted = !isMuted;
        videoPlayer.SetDirectAudioMute(0, isMuted);
        UpdateMuteButtonText(); // Update button text
    }
    void UpdateMuteButtonText()
    {
        if (isMuted)
        {
            muteButton.GetComponentInChildren<TextMeshProUGUI>().text = "Unmute";
        }
        else
        {
            muteButton.GetComponentInChildren<TextMeshProUGUI>().text = "Mute";
        }
    }
}