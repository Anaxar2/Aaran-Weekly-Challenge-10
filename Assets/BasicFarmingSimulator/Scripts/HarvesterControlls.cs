using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HarvesterControlls : MonoBehaviour
{
    // navmesh agent
    [SerializeField] private NavMeshAgent agent;

    // camera
    [SerializeField] private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        // handle for agent
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // input on right mouse button which is 1.
        if (Input.GetMouseButtonDown(1))
        {
            // raycasting
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tomato")
        {
            Destroy(gameObject);
        }
    }*/
}