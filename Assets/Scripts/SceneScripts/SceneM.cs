using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    public string[] LoadLevel;

    public void HeadOverScene()
    {
        for (int i = 0; i < 0; i++)
        {
            SceneManager.LoadScene(LoadLevel[i]);
        }
    }
}
