using Assets.AR_VR_WrapperFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{this} - Start");
        Nesper_611_test test = new Nesper_611_test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
