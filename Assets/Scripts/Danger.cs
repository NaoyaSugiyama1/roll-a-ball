﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

      void OnCollisionEnter(Collision other)
      {
        if( other.gameObject.CompareTag("Player") )
       {
        SceneManager.LoadScene(　SceneManager.GetActiveScene().name　);
       }
      }
}
