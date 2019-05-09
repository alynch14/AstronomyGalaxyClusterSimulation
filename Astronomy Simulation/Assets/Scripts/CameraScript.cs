using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject finalPicture;
    private static Vector3 POSITION_MOVING_TOWARDS = new Vector3(31.7f, 5.7f, -8f);
    private static Quaternion QUATERNION_ROTATING_TOWARDS = new Quaternion(0.0f, -90.0f, 0f, 0f);
    private int angle;
    private Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finalPicture.activeSelf)
        {
            //   transform.Translate(new Vector3(0.1f, 0.1f));
           /* if(Mathf.Abs(transform.position.y - POSITION_MOVING_TOWARDS.y) < 0.5){
                
            }
            else if (Mathf.Abs(transform.position.x - POSITION_MOVING_TOWARDS.x) < 0.5 )
            {
                transform.Translate(new Vector3(0f, -0.1f, 0f));
                transform.localRotation.Set(transform.rotation.x, transform.rotation.y, 90.0f, transform.rotation.w);
                
            }
            else
            {*/
                transform.position = Vector3.Lerp(startPosition.position, POSITION_MOVING_TOWARDS, Time.deltaTime / 2);
            transform.rotation = Quaternion.Lerp(transform.rotation, QUATERNION_ROTATING_TOWARDS, Time.deltaTime / 2);
            //StartCoroutine("RotateCamera");
            
            //}
        }
    }

    IEnumerator RotateCamera()
    {
        while(!(Mathf.Abs(transform.rotation.y +90) < 0.5))
        {
            transform.Rotate(new Vector3(-0.5f, -0.5f, 0.0f));
            yield return new WaitForSeconds(0.1f);
        }
    }
}
