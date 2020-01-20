using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matt_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mattsObj;

    void Update()
    {
        mattsObj.transform.Rotate(3f, 1f, 6f);
    }
}
