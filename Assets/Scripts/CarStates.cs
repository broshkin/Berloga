using UnityEngine;

public class CarStates : MonoBehaviour
{
    public bool inForward = false;
    public bool inBackward = false;
    public bool inDefault = true;

    public void MoveForward()
    {
        if (!inForward)
        {
            if (inDefault)
            {
                GetComponent<Animator>().SetBool("moveForward", true);
                inForward = true;
                inDefault = false;
            }
            if (inBackward)
            {
                GetComponent<Animator>().SetBool("moveForward", true);
                inDefault = true;
                inBackward = false;
            }
            
        }
    }
    public void MoveBackward()
    {
        if (!inBackward)
        {
            if (inDefault)
            {
                GetComponent<Animator>().SetBool("moveBackward", true);
                inBackward = true;
                inDefault = false;
            }
            if (inForward)
            {
                GetComponent<Animator>().SetBool("moveBackward", true);
                inDefault = true;
                inForward = false;
            }

        }
    }
    public void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveForward"))
        {
            GetComponent<Animator>().SetBool("moveForward", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveBackward"))
        {
            GetComponent<Animator>().SetBool("moveBackward", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveForwardFromBackward"))
        {
            GetComponent<Animator>().SetBool("moveForward", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveBackwardFromForward"))
        {
            GetComponent<Animator>().SetBool("moveBackward", false);
        }
    }
}
