using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public static int lastLevel;
    private bool once = true;
    public AudioSource aggd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<VideoPlayer>().isPlaying && once)
        {
            once = false;
            aggd.Play();
            StartCoroutine(load());
        }
    }
    IEnumerator load()
    {
        yield return new WaitWhile(() => GetComponent<VideoPlayer>().isPlaying);
        if (lastLevel == 1)
        {
            SceneManager.LoadScene(2);
        }
        if (lastLevel == 5)
        {
            SceneManager.LoadScene(12);
        }
    }
}
