using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LoadingFinish : MonoBehaviour
{
    [SerializeField]
    VideoPlayer videoPlay;

    // Start is called before the first frame update
    void Start()
    {
        videoPlay.loopPointReached += LoopPoint;
        videoPlay.Play();
    }

    public void LoopPoint(VideoPlayer vp)
    {
        SceneManager.LoadScene("Title1");
    }
}
