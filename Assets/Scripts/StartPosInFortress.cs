using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPosInFortress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (EnterInFortress.lastScene == 3)
        {
            gameObject.transform.position = new Vector3(-6.04400015f, 0.0199999996f, -4.89900017f);
            gameObject.transform.rotation = new Quaternion(0, 0.707106829f, 0, 0.707106829f);
        }
        if (EnterInFortress.lastScene == 4 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            gameObject.transform.position = new Vector3(271.15f, 18.45f, 94.11f);
            gameObject.transform.rotation = new Quaternion(4.30451993e-11f, 0.50224787f, -4.18690152e-11f, 0.864723682f);
        }
        if (EnterInFortress.lastScene == 5)
        {
            gameObject.transform.position = new Vector3(1.33f, 0.02f, -4.13f);
            gameObject.transform.rotation = new Quaternion(0, -0.707106829f, 0, 0.707106829f);
        }
        if (EnterInFortress.lastScene == 7 && SceneManager.GetActiveScene().buildIndex == 6)
        {
            gameObject.transform.position = new Vector3(295.25f, 17.4400005f, 102.540001f);
        }
        if (EnterInFortress.lastScene == 9 && SceneManager.GetActiveScene().buildIndex == 8)
        {
            gameObject.transform.position = new Vector3(294.868988f, 17.7609997f, 102.086998f);
        }
        if (EnterInFortress.lastScene == 11 && SceneManager.GetActiveScene().buildIndex == 10)
        {
            gameObject.transform.position = new Vector3(295.147003f, 17.5370007f, 102.281998f);
        }
        
    }

}
