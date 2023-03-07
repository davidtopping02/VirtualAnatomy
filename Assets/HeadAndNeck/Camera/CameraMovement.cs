using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;//the target object
    private float speed = 10.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at

    void Start()
    {//Set up things on the start method
        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }

    void Update()
    {
        transform.RotateAround(point, transform.right, -Input.GetAxis("Mouse Y") * speed);
        transform.RotateAround(point, transform.up, -Input.GetAxis("Mouse X") * speed);
    }
}
