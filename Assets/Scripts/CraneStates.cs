using UnityEngine;

public class CraneStates : MonoBehaviour
{
    public bool inDefault = true;
    public bool inUp = false;
    public bool inDown = false;
    public void MoveUp()
    {
        if (!inUp)
        {
            if (inDefault)
            {
                GetComponentInChildren<Animator>().SetBool("moveUp", true);
                inUp = true;
                inDefault = false;
            }
            if (inDown)
            {
                GetComponentInChildren<Animator>().SetBool("moveUp", true);
                inDefault = true;
                inDown = false;
            }

        }
    }
    public void MoveDown()
    {
        if (!inDown)
        {
            if (inDefault)
            {
                GetComponentInChildren<Animator>().SetBool("moveDown", true);
                inDown = true;
                inDefault = false;
            }
            if (inUp)
            {
                GetComponentInChildren<Animator>().SetBool("moveDown", true);
                inDefault = true;
                inUp = false;
            }

        }
    }
    public void Update()
    {
        if (GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveUp"))
        {
            GetComponentInChildren<Animator>().SetBool("moveUp", false);
        }
        if (GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveDown"))
        {
            GetComponentInChildren<Animator>().SetBool("moveDown", false);
        }
        if (GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveUpFromDown"))
        {
            GetComponentInChildren<Animator>().SetBool("moveUp", false);
        }
        if (GetComponentInChildren<Animator>().GetCurrentAnimatorStateInfo(0).IsName("moveDownFromUp"))
        {
            GetComponentInChildren<Animator>().SetBool("moveDown", false);
        }
    }
}
