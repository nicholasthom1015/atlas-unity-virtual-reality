using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePalm : MonoBehaviour
{
    public GameObject Physics;
   void OnTriggerEnter(Collider Other)
   {
    if (Other.CompareTag("GameController"))
    {
        Physics.SetActive(true);
    }
   }
}
