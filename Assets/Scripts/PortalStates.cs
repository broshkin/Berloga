using UnityEngine;
using UnityEngine.Playables;
using System.Collections;
using UnityEngine.SceneManagement;

public class PortalStates : MonoBehaviour
{
    public bool isActive = false;
    public bool Once = true;
    public PlayableDirector timeline;
    public GameObject[] vcams;

    public void Activate()
    {
        if(!isActive)
        {
            isActive = true;
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("activatePortal", true);        
        }
    }
    public void Deactivate()
    {
        if (isActive)
        {
            isActive = false;
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("deactivatePortal", true);
        }
    }
    public void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("activatePortal"))
        {
            GetComponent<Animator>().SetBool("activatePortal", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("deactivatePortal"))
        {
            GetComponent<Animator>().SetBool("deactivatePortal", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("activateStatus") && Once)
        {
            Once = false;
            DialogSystem.dialogNum = 8;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
            Destroy(GameObject.Find("InfoCanvas"));
            Camera.main.gameObject.SetActive(false);
            foreach (var a in vcams)
            {
                a.SetActive(false);
            }
            timeline.Play();
            StartCoroutine(Teleport());
        }
    }
    IEnumerator Teleport()
    {
        yield return new WaitWhile(() => timeline.state == PlayState.Playing);
        LevelChanger.lastLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(14);
        
    }
}
