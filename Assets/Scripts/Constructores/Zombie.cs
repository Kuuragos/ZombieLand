using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    public string nombre;
    public int cerebros;
    public int golpe;
    int Z = Random.Range(3, 6);
    public Zombie(string n, int g)
    {
        nombre = n;
        golpe = g;
        cerebros = 0;
        
    }
    
    void Start()
    {
        Zombie zom = new Zombie("rob", 10);
    }
}
