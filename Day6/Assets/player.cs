using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    
    
    public float inc;
    public AudioSource cry;
    public float minPos;
    public float maxPos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
        
    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minPos, maxPos), transform.position.y, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minPos, maxPos), transform.position.y, transform.position.z);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("Restart", 2.5f);
            cry.Play();
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }


}

