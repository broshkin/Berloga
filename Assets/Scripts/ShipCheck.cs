using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCheck : MonoBehaviour
{
    public bool final = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FishV2")
        {
            final = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FishV2")
        {
            final = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Cube")
        {
            GetComponent<ShipStates>().StopAllCoroutines();
            transform.position = GetComponent<ShipStates>().startPos;
            GetComponent<ShipStates>().requests.Clear();
            transform.eulerAngles = new Vector3(0, 0, 0);
            GetComponent<ShipStates>().isFinished = false;
        }
    }
    private void Update()
    {
        if (GetComponent<ShipStates>().isFinished && !final)
        {
            GetComponent<ShipStates>().StopAllCoroutines();
            transform.position = GetComponent<ShipStates>().startPos;
            GetComponent<ShipStates>().requests.Clear();
            transform.eulerAngles = new Vector3(0, 0, 0);
            GetComponent<ShipStates>().isFinished = false;
        }
    }
}
