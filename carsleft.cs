using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
public class carsleft : MonoBehaviour
{
    bool canmove = true;
    bool teleport = false;
    public float speed = 0.05f;
    float directionx = -1.0f;
    float teleportpos = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.x += speed * directionx; // sets position.x to position.x + speed * direction
            if (teleport)
            {
                position.x = teleportpos;
                teleport = false;
            }
            transform.localPosition = position;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        teleport = true;
    }
}
