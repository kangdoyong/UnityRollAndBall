using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
public class parent
{
    public int count = 10;
    public static int id = 1;
    public parent()
    {
        id++;
    }
}

public class Child : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        int count = 10;
        //Debug.Log("Local Position " + transform.localPosition);
        //Debug.Log("World Position " + transform.position);
    }

     int id = 0;
    static void Test()
    {
        int id = 0;
    }

}
