using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShubaDEEDoo : MonoBehaviour
{
    public List<Potato> potatoes;
}

[System.Serializable]
public class Potato
{
    public string name;
    public int potatoEyes;
    public Vector3 vector3;
}
