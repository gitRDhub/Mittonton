using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip SE;
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    public void startbutton()
    {
        AS.PlayOneShot(SE);
        System.Threading.Thread.Sleep(500);
        SceneManager.LoadScene("GameScene");

    }

    public void GameEnd()
    {
      AS.PlayOneShot(SE);
      System.Threading.Thread.Sleep(500);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}