using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//test si le nombre de block n'est pas très grand (<30)
[UnityTest]
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
        NbrBlocks = GameObject.FindGameObjectWithTag("blocks").GetComponent<Transform>().childCount;
	Assert.Less(NbrBlocks, 30);
	Object.Destroy(this.gameObject);
    }
}
