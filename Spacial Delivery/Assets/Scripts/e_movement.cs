using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e_movement : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position += new Vector3(-20 * Time.deltaTime,0,0);
    }
}
