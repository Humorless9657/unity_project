using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PipeMiddleCode : MonoBehaviour
{
    public LogicCode gameLogic;
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicCode>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gameLogic.addScore();
        }
    }
}
