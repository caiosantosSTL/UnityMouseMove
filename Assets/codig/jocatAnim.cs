using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jocatAnim : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent2;
    int v = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("hey");
        anim = GetComponent<Animator>();
        agent2 = GetComponent<NavMeshAgent>();
        //anim.enabled = true;

        //AnimOt();


    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.enabled = true;
            print("GO");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.enabled = false;
            print("GOWWW");
        }

        //**************

        if (Input.GetMouseButtonDown(1)) //0 butao esquerdo
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//para clicar na camera
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent2.SetDestination(hit.point);
                //print("Cordenada "+ray);

            }

        }

    }
    

    void AnimOt()
    {

            if (v == 0)
            {
                anim.enabled = true;
                print("GO");
                v = 1;
            }
            else if (v == 1)
            {
                anim.enabled = false;
                print("GOWW");
            }


    }
}
