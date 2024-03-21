using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogTrigger : MonoBehaviour
{
    public int dialogNum;
    public GameObject father;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DialogSystem.dialogNum = dialogNum;
            if (SceneManager.GetActiveScene().name == "Demo 3")
            {
                if (DialogSystem.onceInFortress)
                {
                    father.GetComponent<DialogSystem>().ShowMessage();
                }
            }
            else
            {
                father.GetComponent<DialogSystem>().ShowMessage();
            }
            Destroy(gameObject);
        }
    }
}
