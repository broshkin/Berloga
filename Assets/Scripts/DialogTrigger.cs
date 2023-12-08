using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public int dialogNum;
    public GameObject father;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DialogSystem.dialogNum = dialogNum;
            father.GetComponent<DialogSystem>().ShowMessage();
            Destroy(gameObject);
        }
    }
}
