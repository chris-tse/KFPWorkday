using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drumstick : MonoBehaviour
{
    public Points scoreCounter;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(-1f, 1f);
        scoreCounter = GameObject.Find("Points").GetComponent<Points>();
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Character")
        {
            scoreCounter.Increment();
        }
        Destroy(gameObject);
    }
}
