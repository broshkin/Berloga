using UnityEngine;

public class MirrorLines : MonoBehaviour
{
    public bool blocked = false;
    public GameObject rayPrefab;
    private GameObject childRay;
    public GameObject parentRay;
    public GameObject lightTarget;
    public Ray ray = new Ray();

    private void Start()
    {
        blocked = false;
        lightTarget = null;
        childRay = null;
    }
    private void Update()
    {
        ray = new Ray();
        RaycastHit hit;
        ray.origin = transform.position;
        if (gameObject.name == "MirrorRay")
        {
            ray.direction = Vector3.down;
        }
        else
        {
            ray.direction = Vector3.Reflect(parentRay.GetComponent<MirrorLines>().ray.direction, parentRay.GetComponent<MirrorLines>().lightTarget.transform.forward);
        }
        Debug.DrawRay(ray.origin, ray.direction * 25);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "Mirror" && !hit.collider.gameObject.GetComponent<MirrorBool>().withRay)
            {
                lightTarget = hit.collider.gameObject;
                hit.collider.gameObject.GetComponent<MirrorBool>().withRay = true;
                childRay = Instantiate(rayPrefab, hit.point, Quaternion.LookRotation(Vector3.Reflect(ray.direction, lightTarget.transform.forward)) * Quaternion.Euler(-90, 0, 0));
                childRay.GetComponent<MirrorLines>().parentRay = gameObject;
                childRay.transform.localScale = new Vector3(1, 0.1f, 1);
            }
            if (hit.collider.gameObject == lightTarget)
            {
                var heading = lightTarget.transform.position - transform.position;
                var distance = heading.magnitude;
                var direction = heading / distance;
                var reflVec = Vector3.Reflect(direction, lightTarget.transform.up);
                childRay.transform.position = hit.point;
                childRay.GetComponent<MirrorLines>().ray.origin = hit.point;
                childRay.transform.rotation = Quaternion.LookRotation(reflVec) * Quaternion.Euler(-90, 0, 0);
            }
            else
            {
                if (lightTarget)
                {
                    lightTarget.GetComponent<MirrorBool>().withRay = false;
                }
                if (childRay)
                {
                    RayDie(childRay);
                } 
            }
        }
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, hit.distance / 2, gameObject.transform.localScale.z);
        gameObject.transform.rotation = Quaternion.LookRotation(ray.direction) * Quaternion.Euler(-90, 0, 0);


    }
    public void RayDie(GameObject cr)
    {
        if (cr.GetComponent<MirrorLines>().childRay)
        {
            RayDie(cr.GetComponent<MirrorLines>().childRay);
        }
        if (cr.GetComponent<MirrorLines>().lightTarget)
        {
            cr.GetComponent<MirrorLines>().lightTarget.GetComponent<MirrorBool>().withRay = false;
        }
        Destroy(cr);
    }
}
