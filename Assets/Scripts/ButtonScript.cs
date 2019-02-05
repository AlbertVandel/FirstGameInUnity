using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void printText()
    {
        print("button was pressed");
    }

    public void playSound()
    {
        GetComponent<AudioSource>().Play();
        
    }

    public void instantiatePurpleCube()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
