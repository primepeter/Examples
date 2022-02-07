using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.AR_VR_WrapperFramework;

public class Dummy : MonoBehaviour
{
    // Start is called before the first frame update
    public Nesper_611_test nesper;
    void Start()
    {
        Debug.Log("Start");
        if (nesper == null)
        {
            nesper = new Nesper_611_test();
        }
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
