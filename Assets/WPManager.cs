﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct Link
{
   
    public enum direction { UNI, BI }

    public GameObject node1;

    public GameObject node2;

    public direction dir;
}




public class WPManager : MonoBehaviour
{
                                                                                        //Cria as variaveis que serao usadas
    public GameObject[] waypoints;


    public Link[] links;


    public Graph graph = new Graph();


    void Start()
    {
                                                                                        //Caso o array waypoints for maior que 0, é adcionado um node  
        if (waypoints.Length > 0)
        {
         
            foreach (GameObject wp in waypoints)
            {
              
                graph.AddNode(wp);
            }

                                                                                       //Para cada link, adciona um edge para o graphs  
            foreach (Link l in links)
            {
               
                graph.AddEdge(l.node1, l.node2);
            
                if (l.dir == Link.direction.BI)
                  
                    graph.AddEdge(l.node2, l.node1);
            }
        }
    }
                                                                                       //Cria um caminho de acordo com os pontos
    void Update()
    {
        graph.debugDraw();
    }
}

