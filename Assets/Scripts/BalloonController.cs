using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float scalefactor = 1.2f;

    public float maxScale = 3f;

    private void Start()
    {
        if (scalefactor <= 1)
        {
            print("Value too low. The balloon needs to grow!");
            
        }

    }

    private void OnMouseDown()
    {
        if (scalefactor > 1)
            transform.localScale *= scalefactor;

        if (transform.localScale.x > maxScale)
            Destroy(gameObject);
    }


}
