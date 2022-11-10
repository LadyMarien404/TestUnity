using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript2 : MonoBehaviour
{
    public bool alive               = true;
    public int score                = 0;
    public List<int> values         = null;
    public GameObject myGameObject  = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alive = true;
        score = 1;

        myGameObject = gameObject;
        myGameObject.SetActive(true);

        values.Add(1);
        values.Add(5);
        values.Add(1);

        int count = 0;
        float total = 0;

        foreach(int v in values)
        {
            total = total + v;
            count++;
        }

        float average = total / count;

        Debug.Log("Average value is \"" + average + "\"");
    }
}
