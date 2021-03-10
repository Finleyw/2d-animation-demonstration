using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Destroy : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(gameObject,2.02f);
    }
}
