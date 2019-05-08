using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject finalPicture;
    private static Vector3 POSITION_MOVING_TOWARDS = new Vector3(31.7f, 5.7f, -8f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!finalPicture.activeSelf && !transform.position.Equals(POSITION_MOVING_TOWARDS))
        {
            transform.Translate(new Vector3(0.1f, 0.1f));
            transform.Rotate(new Vector3(-0.5f, -0.5f, 0));
        }
    }
}
