using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clickSetting(){
        GameObject canvas = GameObject.Find("SettingFrameCanvas");
        Transform panel = canvas.transform.Find("Panel");
        panel.gameObject.SetActive(true);
    }
}
