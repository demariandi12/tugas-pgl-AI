using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _agent;
    public GameObject Player;
    public float EnemyDistanceRun = 4.0f;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    
    void Start ()
    {
        _agent = GetComponent<NavMeshAgent>();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }
    void Awake ()
    {
        playerHealth = Player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
    }
    void Update ()
    {
        nav.SetDestination (Player.transform.position);
        float distance = Vector3.Distance (transform.position, Player.transform.position);
    
        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination (newPos);
        }
    }
}