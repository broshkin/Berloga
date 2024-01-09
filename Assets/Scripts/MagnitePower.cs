using UnityEngine;

public class MagnitePower : MonoBehaviour
{
    public GameObject target;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MagnitePower>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 f = target.transform.position + new Vector3(4, 0, 0) - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce(f.normalized * power / f.magnitude);
    }
}
