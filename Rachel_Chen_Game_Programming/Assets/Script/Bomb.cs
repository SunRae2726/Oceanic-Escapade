using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float timer = 0f;
    public float lifetime = 1f;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= lifetime)
        {
            GameObject explosion = Instantiate(explosionPrefab);
            explosion.transform.position = transform.position;

            Destroy(gameObject);
        }
        
    }
}
