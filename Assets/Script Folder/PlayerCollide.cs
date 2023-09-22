using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//to interact texts in Unity
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour
{

    bool WandInHand = false;
    bool CollideWithEnemy = false;

    public TMP_Text speechUI;
    //Another visually similar method is [SerializeField]
    //Using public means this variable can be used in another script, thr bonus effect is it can be visually seem in the inspector
    //inspectors OVERWRITES the code

    public string enemyDialogue = "OwO";


    public GameObject textObject;//stores the text and panel
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionEnter2D(Collision2D collision)//be careful of the 2D or 3D function
    {
        Debug.Log("Collided with"+ collision.gameObject.name);//Debug.Log: print to the console the name of the object being collided
        // assembling the 'instance' in gamemaker, making it a unit of thing
        //GameObject is a class to store gameObejct variable, gameObject is specific gameObject

        if(collision.gameObject.name == "Enemy")
        {
            CollideWithEnemy = true;
            textObject.SetActive(true);
            speechUI.text = enemyDialogue;
            InvokeRepeating("HidePanel", 0.5f, 0.0f);
        }

        //textObject.SetActive(false);


    }

    void HidePanel()
    {
        textObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Overlapped with" + collision.gameObject.name);

        if (collision.gameObject.name == "Wand")
        {
            WandInHand = true;
            Destroy(collision.gameObject);
            SceneManager.LoadScene("EndScene",LoadSceneMode.Single);
        }
    }
}
