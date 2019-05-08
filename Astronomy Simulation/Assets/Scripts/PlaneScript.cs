using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(camera.transform.position.y-transform.position.y > 40.0f)
        {
            transform.Translate(0.0f, 0.01f, 0.0f, Space.World);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
