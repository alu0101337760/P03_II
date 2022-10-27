using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNotifier : MonoBehaviour
{
    public delegate void PlayerCallback();
    public event PlayerCallback OnObjectA;
    public event PlayerCallback OnObjectBExit;
    public event PlayerCallback OnObjectB;
    public event PlayerCallback OnObjectC;

    public static PlayerNotifier instance;

    private void Awake()
    {
        if(PlayerNotifier.instance != null)
        {
            return;
        }
        PlayerNotifier.instance = this;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "A")
        {
            OnObjectA();
        }
        else if (collision.gameObject.tag == "B")
        {
            OnObjectB();
        }
     
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "B")
        {
            OnObjectBExit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
     if(other.tag == "C")
        {
            OnObjectC();
        }   
    }
}
