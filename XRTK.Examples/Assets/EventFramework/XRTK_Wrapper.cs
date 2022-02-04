using Assets.AR_VR_WrapperFramework;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;
using XRTK.Interfaces;
using XRTK.Interfaces.InputSystem;
using XRTK.Services;


//[...]any instance of the MonoBehaviour will have its callback functions executed while the Editor is in Edit Mode too."
[ExecuteInEditMode] //TODO ist das wirlich nötig?" 
[DisallowMultipleComponent]
public sealed class XRTK_Wrapper : MonoBehaviour
{
    private static MixedRealityToolkit XRTK_Instance;
    //private IReadOnlyDictionary<System.Type, XRTK.Interfaces.IMixedRealitySystem> InputSystem = MixedRealityToolkit.ActiveSystems?.Where(system => (system. != null && system is InputSystem).First();
    private IMixedRealityInputSystem InputSystem;
    private EventCorrelator correlator = new EventCorrelator(); //TODO loose coupling
    ReadOnlyObservableCollection<GameObject> EventListener;
    ReadOnlyObservableCollection<GameObject> cache;

    public bool IsInitialized { get; private set; }

    private void Awake()
    {
        XRTK_Instance = gameObject.GetComponent<MixedRealityToolkit>() as MixedRealityToolkit;
        if (MixedRealityToolkit.IsInitialized && !this.IsInitialized)
        {
            Initialize();
        }
    }

    public void Initialize()
    {
        print("XRTK_Wrapper Initializing");
        MixedRealityToolkit.TryGetSystem<XRTK.Interfaces.InputSystem.IMixedRealityInputSystem>(out InputSystem);
        //EventListener = new ReadOnlyObservableCollection<GameObject>((ObservableCollection<GameObject>)InputSystem?.EventListeners);
        if (correlator == null || InputSystem == null) //TODO
        {
            Debug.Log($"The InputSystem is {InputSystem.ToString()} \n The Correlator is {correlator}");
            return;
        }
        InputSystem.OnInputEvent += correlator.dispatchEvent;
        IsInitialized = true;
        Debug.Log(IsInitialized ? "Init successfull" : "Init failed");
        Nesper_611_test test= new Nesper_611_test();
    }

    private void OnEnable()
    {
        //XRTK_Instance = gameObject.GetComponentInChildren(typeof(MixedRealityToolkit), true) as MixedRealityToolkit;
        if (MixedRealityToolkit.IsInitialized && !this.IsInitialized)
        {
            Initialize();
        }
    }

    private void Start()
    {
        //XRTK_Instance = gameObject.GetComponentInChildren(typeof(MixedRealityToolkit), true) as MixedRealityToolkit;
        //if (MixedRealityToolkit.IsInitialized && !this.IsInitialized)
        //{
        //    Initialize();
        //}
    }

    private void Update()
    {
    }

    private void OnDisable()
    {
        IsInitialized = false;
        print("disabled");
    }

    private void OnDestroy()
    {
        print("gettin killed!");
    }
}
