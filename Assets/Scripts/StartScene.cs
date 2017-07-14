using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{


    public MovieTexture MoveSource;
    private bool isPlaying = true;
    private bool hasClickOnce = false;

    // Use this for initialization
    void Start()
    {
        MoveSource.loop = false;
        MoveSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasClickOnce && Input.GetMouseButtonUp(0)) hasClickOnce = true;
        else if (hasClickOnce && Input.GetMouseButtonUp(0) && isPlaying) StopMovie();
    }


    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), MoveSource);
        if (isPlaying && hasClickOnce)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, Screen.width / 2 + 100, Screen.height / 2 + 20), "再次单击退出播放");
        }
 
    }

    private void OnMouseUp()
    {

    }

    private void StopMovie()
    {
        MoveSource.Stop();
        isPlaying = false;
    }
}
