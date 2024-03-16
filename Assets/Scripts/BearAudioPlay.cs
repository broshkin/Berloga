using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAudioPlay : MonoBehaviour
{
    IEnumerator PlayAudioMusic()
    {
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void StartPlayCoroutine()
    {
        StartCoroutine(PlayAudioMusic());
    }
}
