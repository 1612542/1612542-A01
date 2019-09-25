using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{
    Vector2 pos;
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<SpriteRenderer>().flipX = true;
                pos.x += speed;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
                pos.x -= speed;
            }
            transform.position = pos;
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        else
        {
            //transform.position = pos;
            GetComponent<Animator>().SetBool("isRunning", false);
        }
    }
}
