using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public bool alive = true;
    public int score = 0;
    [Range(0, 10)]
    public float speed = 1.0f;
    [Header("Text Variables")]
    [TextArea]
    public string description = "";
    [HideInInspector]
    public GameObject myGameObject = null;
    public Light myLight = null;
    private BoxCollider boxCollider = null;

    private void Awake()
    {
        myGameObject = gameObject;
        boxCollider = GetComponent<BoxCollider>();
        myLight = GetComponent<Light>();

    }

    // Start is called before the first frame update
    void Start()
    {
        //Health cubeHealth = new Health(100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //myLight.enabled = !myLight.enabled;
            gameObject.SetActive(false);

        }

        //transform.Translate(new Vector3(0, 0, 1));
        //transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        //transform.Rotate(Vector3.up, 1);
        //transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void FixedUpdate()
    {
        
    }
}
