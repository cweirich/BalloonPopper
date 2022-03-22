using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 0.1f;
    public float maxPosition = 3;
    private Vector3 direction = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * direction;

        if ((transform.position.y > maxPosition && speed > 0) || (transform.position.y < -maxPosition && speed < 0))
            speed *= -1;
    }


}
