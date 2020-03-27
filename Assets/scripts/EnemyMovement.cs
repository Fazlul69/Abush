using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform target;
    public float speed;

    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Hero").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameManager.instance.Player.transform.position;
        if (Vector3.Distance(playerPos, gameObject.transform.position) > 2)
        {
            nav.enabled = true;
            //enemy find the player
            nav.SetDestination(target.position);
        }
        else
        {
            nav.enabled = false;
        }
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }
}
