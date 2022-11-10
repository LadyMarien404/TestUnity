using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public GameObject myGameObject = null;
    // Start is called before the first frame update
    void Start()
    {
        myGameObject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 0.2f);
    }
}
