using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
   // public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * Time.deltaTime * speed);
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Player"))
                {
            Time.timeScale = 0.5f;

        }
       
       
    }
    private void OnCollisionExit(Collision collision)
    {
        Time.timeScale = 1.0f;
    }

}
