using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            print("Respect");
        }
    }

    void KeyPressF()
    {
        if (Input.GetKey("f"))
        {
            print("Respect");
        }
    }
}
