using UnityEngine;
using UnityEngine.Video;

public class DebugVideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.prepareCompleted += OnVideoPrepared;
            videoPlayer.Prepare();
        }
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video Prepared, starting playback.");
        videoPlayer.Play();
    }

    void Update()
    {
        if (videoPlayer.isPlaying)
        {
            Debug.Log("Video is playing.");
        }
    }
}
