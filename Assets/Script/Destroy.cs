using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DeObj;
    public int DTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(DeObj,DTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
