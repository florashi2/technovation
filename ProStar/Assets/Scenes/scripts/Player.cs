using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float yincrement;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yincrement);
            transform.position = targetPos;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            targetPos = new Vector2(transform.position.x, transform.position.y - yincrement);
            transform.position = targetPos;
        }
            
            
    }
}
