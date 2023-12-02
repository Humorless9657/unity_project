using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCode : MonoBehaviour
{
    public bool gameEnd = false;
    public float power;
    public Rigidbody2D rigidBody;
    public LogicCode gameLogic;
    

    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Mouse0)) && gameEnd == false))
        {
            rigidBody.velocity = Vector2.up * power;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameEnd = true;
        gameLogic.gameOver();
    }
}
