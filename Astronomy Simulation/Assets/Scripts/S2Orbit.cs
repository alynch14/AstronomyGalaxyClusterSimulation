using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2Orbit : MonoBehaviour
{
    public GameObject blackHole;
    private Transform blackHolePosition;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        blackHolePosition = blackHole.transform;
    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.Abs(transform.localPosition.y/2.0f);
        gameObject.transform.RotateAround(new Vector3(blackHolePosition.position.x, (float)(blackHolePosition.position.y+2.0), blackHolePosition.position.z), blackHolePosition.position, angle);
    }
}
