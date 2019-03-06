using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaris : MonoBehaviour
{
    private Vector2 kijelzoMeret;
    private float objectSzeleseg;
    private float objectMagassag;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        kijelzoMeret = new Vector2(Camera.main.aspect * Camera.main.orthographicSize + objectSzeleseg, Camera.main.orthographicSize + objectMagassag);
        objectSzeleseg = transform.localScale.x / -2;
        objectMagassag = transform.localScale.y / -2;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -kijelzoMeret.x)
        {
            transform.position = new Vector2(-kijelzoMeret.x, transform.position.y);

        }else if(transform.position.x > kijelzoMeret.x)
        {
            transform.position = new Vector2(kijelzoMeret.x, transform.position.y);
        }
        if(transform.position.y < -kijelzoMeret.y)
        {
            transform.position = new Vector2(transform.position.x, -kijelzoMeret.y);
        }
        else if(transform.position.y > kijelzoMeret.y)
        {
            transform.position = new Vector2(transform.position.x, kijelzoMeret.y);
        }
    }
}
