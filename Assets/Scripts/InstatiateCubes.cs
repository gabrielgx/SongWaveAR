using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateCubes : MonoBehaviour
{
    public GameObject sampleCubesPrefab;
    GameObject[] _SampleCube = new GameObject[512];
    public float maxScale;
    void Start()
    {
       for (int i = 0; i< 512; i++)
        {
            GameObject instantiateCube = (GameObject)Instantiate(sampleCubesPrefab);
            instantiateCube.transform.position = this.transform.position;
            instantiateCube.transform.parent = this.transform;
            instantiateCube.name = "SampleCube" + i;
            this.transform.localEulerAngles = new Vector3(0, -0.703125f * i, 0);
            instantiateCube.transform.position = Vector3.forward * 100;
            _SampleCube[i] = instantiateCube;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<512; i++)
        {
            if(_SampleCube != null)
            {
                _SampleCube[i].transform.localScale = new Vector3(10, (AudioSpectrum._sample[i] * maxScale)  + 2,10);
            }
        }
    }
}
