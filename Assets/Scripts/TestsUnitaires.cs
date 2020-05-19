using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestsUnitaires : MonoBehaviour
{
	public int NbrBlocks = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NbrBlocks	=GameObject.FindGameObjectWithTag("blocks").GetComponent<Transform>().childCount ;
    }
}
