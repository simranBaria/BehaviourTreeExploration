using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Thief : MonoBehaviour
{
    NavMeshAgent nmAgent;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        // Head towards treaure
        nmAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Treasure");
        nmAgent.SetDestination(target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Die if hit by guard
        if (collision.collider.CompareTag("Guard")) Destroy(gameObject);
    }
}
