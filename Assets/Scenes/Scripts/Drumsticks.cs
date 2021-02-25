using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drumsticks : MonoBehaviour
{
    public float delay = 1f;
    public GameObject drumstick;
    private float scalingFactor = 4;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        float randomX = Random.Range(-8f, -5f) * scalingFactor;
        float randomY = Random.Range(1f, 5f) * scalingFactor;

        GameObject newDrumstick = Instantiate(drumstick, new Vector3(10, 2, 0), Quaternion.identity);
        newDrumstick.GetComponent<Rigidbody2D>().velocity = new Vector2(randomX / scalingFactor, randomY / scalingFactor);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
