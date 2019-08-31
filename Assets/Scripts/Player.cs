using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField, Range(-10f,10f)]
   float movSpeed;
}
void Update(){
    Vector axis= new Vector2(Input.getAxis("Horizontal",Input.getAxis("Vertical")))
}
