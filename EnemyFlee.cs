using System.Collections;
using UnityEngine.AI;
using UnityEngine;

public class EnemyFlee : MonoBehaviour 
{
    private NavMeshAgent _agent;
    public GameObject Player;
    public float EnemyDistanceRun = 4.0f;
    void Start ()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

// Update is called once per frame
    void Update () 
    {
        float distance = Vector3.Distance (transform.position, Player.transform.position);
        
        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination (newPos);
        }
    }
}