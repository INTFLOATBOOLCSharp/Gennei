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
        //ループが行われるタイミングでのイベント
        videoPlay.loopPointReached += LoopPoint;
        videoPlay.Play();
    }

    public void LoopPoint(VideoPlayer vp)
    {
        //動画再生完了時の処理にtitle1をロードする処理
        SceneManager.LoadScene("Title1");
    }
}
