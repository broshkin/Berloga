using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OffCamsWhenTimeline : MonoBehaviour
{
    public GameObject[] cams;
    public PlayableDirector timeline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (timeline.state is not PlayState.Playing)
        {
            foreach (var a in cams)
            {
                if (!a.activeSelf)
                {
                    a.SetActive(true);
                }
            }
        }
     else
        {
            foreach (var a in cams)
            {
                if (a.activeSelf)
                {
                    a.SetActive(false);
                }
            }
        }
    }
}
