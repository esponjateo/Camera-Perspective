using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abstract : MonoBehaviour
{
    [SerializeField] protected Camera playerCamera;
    [SerializeField] protected float walkSpeed;
    [SerializeField] protected float runSpeed;
    [SerializeField] protected float jumpPower;
    [SerializeField] protected float gravity; 
}
