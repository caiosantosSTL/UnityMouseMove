using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveMouse : MonoBehaviour
{
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // pegar componente


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //0 butao esquerdo
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//para clicar na camera
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
                //print("Cordenada "+ray);

            }
            
        }



    }


}
