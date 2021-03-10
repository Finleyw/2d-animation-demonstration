using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instan : MonoBehaviour
{
    public GameObject myPrefab;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("s"))
        {
            Instantiate(myPrefab);
        }
        else
        {
            
        }
    }
}
