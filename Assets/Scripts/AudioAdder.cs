using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioAdder : MonoBehaviour
{
    public AudioMixer audMix;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var a in GameObject.FindObjectsOfType<AudioSource>())
        {
            a.GetComponent<AudioSource>().outputAudioMixerGroup = audMix.FindMatchingGroups("Master")[0];
        }
    }


}
