using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float xRange = 10.0f;
    public float zRange = 30.0f;


    private Rigidbody playerRB;
    public float moveForce = 20;
    public bool gameOver = false;
    public bool win = false;



    // Start is called before the first frame update
    void Start()
    {

        playerRB = GetComponent<Rigidbody>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
            Movement();
       
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Obstacle"))
        {
          
            { 
                gameOver = true;
                Debug.Log("GameOver");
            }
        }
        if (other.CompareTag("Win"))
        {
            if (!gameOver)
            {
                win = true;
                Debug.Log("You Win");    
            }
          
               

        }

    }


    private void Movement()
    {
        //for player horizontal movement Range
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //for player vertical movement Range
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (!gameOver)
        {
            if (!win)
            {
                //Vertical Movement

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    playerRB.AddForce(Vector3.forward * moveForce, ForceMode.Impulse);

                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    playerRB.AddForce(Vector3.back * moveForce, ForceMode.Impulse);

                }

                //Horizontal Movement
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    playerRB.AddForce(Vector3.right * moveForce, ForceMode.Impulse);


                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    playerRB.AddForce(Vector3.left * moveForce, ForceMode.Impulse);


                }

            }

        }

    }

}
