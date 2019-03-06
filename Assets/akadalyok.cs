using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akadalyok : MonoBehaviour
{
    public float spawn = 2f;
    public GameObject akadaly;

    float rand;
    Vector2 spawnHely;
    public float kovetkezoSpawn = 0.0f;

    public int sebesseg = -2;

    // Start is called before the first frame update
    void Start()
    {
        float mozgas = 0.2f;

        
        GetComponent<Rigidbody2D>().velocity = new Vector2(mozgas * sebesseg, GetComponent<Rigidbody2D>().velocity.y);

      
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > kovetkezoSpawn)
        {
            kovetkezoSpawn = Time.time + spawn;
            rand = Random.Range(-0.9f, 0.9f);
            spawnHely = new Vector2(rand, transform.position.y);
            Instantiate(akadaly, spawnHely, Quaternion.identity);
        }

    }
}
