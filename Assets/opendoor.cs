using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
public Animator anim;

   void OnTriggerEnter(Collider other)
   {
anim.SetBool("Open Doors", true);
   }

    void OnTriggerExit(Collider other)
   {
anim.SetBool("Open Doors", false);
   }
}
