using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float moveSpeed = 5f;

    SpriteRenderer gameobject_SpriteRenderer;

    // Start is called before the first frame update
    //equivalent to 'create' in gamemaker
 
    void Start(){ 
        gameobject_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    //equivalent to 'step' in gamemaker

    void Update()
    {
        Vector3 newPos = transform.position;//consist of 3 floats and 1 variable

        float inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPos.y += Time.deltaTime * moveSpeed;
            //move y position up
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPos.y -= Time.deltaTime * moveSpeed;
            //move y position down
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPos.x += Time.deltaTime * moveSpeed;
            //move x position right

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPos.x -= Time.deltaTime * moveSpeed;
            //move x position left
        }

        transform.position = newPos;

        if (inputHorizontal > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (inputHorizontal < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

}

