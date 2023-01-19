using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        target.transform.eulerAngles += Vector3.up * Time.deltaTime * speed;
    }
}
