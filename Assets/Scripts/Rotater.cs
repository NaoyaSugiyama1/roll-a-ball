using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
		transform.Rotater(new Vector3(0,90,0) * Time.deltaTime,
			Space.World);
    }
}
