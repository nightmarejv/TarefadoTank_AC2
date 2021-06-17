using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    Transform goal;
    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;
                                                                                                        //Faz a importação do navmesh
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
                                                                                                        //puxa as informações do wpmanager para o wps
        wps = wpManager.GetComponent<WPManager>().waypoints;
                                                                                                        //Puxa o componente do agent para o tank ter movimento
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    

    public void GoToHeli()
    {
                                                                                                        //Cria um destino para o tank ir até o heli
        agent.SetDestination(wps[9].transform.position);
    }

    



    public void GoToRuin()
    {
                                                                                                        //Cria um destino para o tank ir até a ruina
        agent.SetDestination(wps[5].transform.position);      
    }
    



    public void GoToFabrica()
    {
                                                                                                        //Cria um destino para o tank ir até a fabrica
        agent.SetDestination(wps[10].transform.position);
    }

  
}
