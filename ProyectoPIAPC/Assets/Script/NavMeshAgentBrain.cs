using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshAgentBrain : MonoBehaviour
{

    public bool MeMuevo;
    public GameObject Checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MeMuevo == true)
        {
            GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Checkpoint.transform.position);
        }
    }
}
