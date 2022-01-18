using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//for moving car in X direction
public class MoveLeft : MonoBehaviour
{

    private PlayerController playerControllerScript;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            if (!playerControllerScript.win)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            
        }

    }
}
