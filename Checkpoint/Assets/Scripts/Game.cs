using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private float velocity = 8;
    private Transform playerTransform;
    private int i = 0;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        float movex = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float movey = Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        playerTransform.Translate(movex, movey, 0);

        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            i++;
            Destroy(collision.gameObject);
            print("Collected");
            print(i+  "Coins collected");
        }
    }

    
    
        


}
