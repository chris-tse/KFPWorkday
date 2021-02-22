using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drumsticks : MonoBehaviour
{
    public float delay = 1f;
    public GameObject drumstick;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    void Spawn()
    {
        float randomX = Random.Range(-8f, -3f);
        float randomY = Random.Range(1f, 4f);

        var newDrumstick = Instantiate(drumstick, new Vector3(5, 2, 0), Quaternion.identity);
        newDrumstick.GetComponent<Rigidbody2D>().velocity = new Vector2(randomX, randomY);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
