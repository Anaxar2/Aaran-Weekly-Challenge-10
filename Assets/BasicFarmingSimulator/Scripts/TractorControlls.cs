using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TractorControlls : MonoBehaviour
{
    // navmesh agent
    [SerializeField] private NavMeshAgent agent;

    // camera
    [SerializeField] private Camera cam;

    // index with crop prefabs
    public GameObject[] cropPrefab;
    public int cropIndex;

    // Start is called before the first frame update
    void Start()
    {

        // handle for agent
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // input on left mouse button which is 0.
        if (Input.GetMouseButtonDown(0))
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Field")
        {
            other.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}