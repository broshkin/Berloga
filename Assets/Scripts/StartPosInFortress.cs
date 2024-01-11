using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosInFortress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (EnterInFortress.lastScene == 3)
        {
            gameObject.transform.position = new Vector3(-7.44f, 0.02f, -4.13f);
            gameObject.transform.rotation = new Quaternion(0, 0.707106829f, 0, 0.707106829f);
        }
        if (EnterInFortress.lastScene == 4)
        {
            gameObject.transform.position = new Vector3(271.15f, 18.45f, 94.11f);
            gameObject.transform.rotation = new Quaternion(4.30451993e-11f, 0.50224787f, -4.18690152e-11f, 0.864723682f);
        }
        if (EnterInFortress.lastScene == 5)
        {
            gameObject.transform.position = new Vector3(1.33f, 0.02f, -4.13f);
            gameObject.transform.rotation = new Quaternion(0, -0.707106829f, 0, 0.707106829f);
        }
    }

}
