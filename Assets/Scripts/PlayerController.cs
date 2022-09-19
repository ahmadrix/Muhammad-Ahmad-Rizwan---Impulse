using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 8f;        //speed of the player variable
    private Rigidbody playerRb;
    public Vector3 turn;    
    [SerializeField] private  Camera mainCamera;

    //private float sesnsitivity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");         //getting horizontal input keys
        float verticalInput = Input.GetAxis("Vertical");             //geting vertical input keys

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);            //moving player in up/down direction with input
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);           //moving player in left/right direction with input

    

        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }
    }
}
