using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour
{
    public int point = 1;
    public float speed;

    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // player get a point

            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<Player>().score += point;
            Debug.Log("score: " + other.GetComponent<Player>().score);
            Destroy(gameObject);

        }
    }
}
