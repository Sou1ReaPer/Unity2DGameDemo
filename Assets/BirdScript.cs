using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength;

    public LogicScript logic;
    public bool isBirdLive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBirdLive)
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
        }

        float y = gameObject.transform.position.y;

        if(y > 16.0f || y < -16.0f)
        {
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isBirdLive = false;
        logic.GameOver();
    }
}
