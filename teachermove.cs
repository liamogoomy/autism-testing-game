using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachermove : MonoBehaviour
{
    public float speed = 0.04f;
    float directionx = 1.0f;
    int step;
    public bool inplace = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (step <= 500)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.x += speed * directionx; // sets position.x to position.x + speed * direction
            transform.localPosition = position;
            step += 1;
        }
        if (step > 500)
        {
            inplace = true;
        }
    }
}
