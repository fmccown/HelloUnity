using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        
        print("Hello Unity!");
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(myCube);

        print("Update called");
    }
}
