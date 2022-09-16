using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemies : MonoBehaviour
{
    private Transform Player;
    private Rigidbody enemyRb;
    public NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        enemy = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
        transform.LookAt(Player.position);

    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Walls"))
        {
            Destroy(gameObject);
        }
    }
}
