using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class enmy : MonoBehaviour
{

    Rigidbody RB;
    public float speed;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        move();
    }

    void move()
    {
        RB.velocity = new Vector3(0, 0, speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "dstry")
        {
            Destroy(gameObject);
        }
    }

}