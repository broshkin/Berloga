using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveStartMenu : MonoBehaviour
{
    private Vector3 nextPosition;
    public GameObject canvas;
    public bool once = true;
    public AudioSource papich;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(canvas.GetComponent<RectTransform>().rect.height);
        nextPosition = new Vector3(transform.localPosition.x, -gameObject.GetComponent<RectTransform>().rect.height * 190 + transform.localPosition.y + canvas.GetComponent<RectTransform>().rect.height + 10, transform.localPosition.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (once)
        {
            papich.Play();
            once = false;
        }
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPosition, Time.deltaTime * 200);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (transform.localPosition == nextPosition)
        {
            SceneManager.LoadScene(1);
        }
    }
}
