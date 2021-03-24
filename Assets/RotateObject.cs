using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    public GameObject objectRotate;
    public float rotateSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
