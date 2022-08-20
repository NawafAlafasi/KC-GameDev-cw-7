using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject Enemy;
    public float delay;
    public Transform leftPos;
    public Transform mddlePos;
    public Transform rightPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int randomPos = Random.Range(1, 4);

        if (randomPos == 1)
        {
            Instantiate(Enemy, leftPos);
        }
        else if (randomPos == 2)
        {
            Instantiate(Enemy, mddlePos);
        }
        else
        {
            Instantiate(Enemy, rightPos);
        }
        
    }

}
