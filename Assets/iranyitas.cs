using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iranyitas : MonoBehaviour
{


    private float sebesseg = 6.5f;
   
    // Start is called before the first frame update
    void Start()
    {



    }
   
   
    // Update is called once per frame
    void Update()
    {
      


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(Vector3.forward * 1);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(Vector3.forward * -1);
        }

        var rigidbody = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 v = transform.position;
            v.y += sebesseg*Time.deltaTime;
            transform.position = v;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 v = transform.position;
            v.y -= sebesseg * Time.deltaTime;
            transform.position = v;

        }
        
       
        
    }
}
