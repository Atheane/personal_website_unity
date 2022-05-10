using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PortefolioController : MonoBehaviour
{
    public VideoPlayer _videoPlayer;
    private string _videoUrl = "https://theroccob.github.io/video/video.mp4";

    public void OnClickButtonPlay()
    {
        _videoPlayer.url = _videoUrl;
        _videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        _videoPlayer.EnableAudioTrack(0, true);
        _videoPlayer.Play();
    }

    public void OnClickButtonClose()
    {
        SceneManager.LoadScene("StartPage", LoadSceneMode.Single);
    }

}