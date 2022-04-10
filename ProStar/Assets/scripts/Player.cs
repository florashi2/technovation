using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public Text healthDisplay;
    public Text scoreDisplay;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (health <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        healthDisplay.text = "HP "+health.ToString();
        scoreDisplay.text = "PT "+score.ToString();
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed* Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yincrement);  
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - yincrement); 
        }
    }
}
