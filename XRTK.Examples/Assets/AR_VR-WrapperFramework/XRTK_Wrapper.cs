using Assets.AR_VR_WrapperFramework;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;
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

    private void Awake()
    {
    }

    private void OnEnable()
    {
        XRTK_Instance = gameObject.GetComponentInChildren(typeof(MixedRealityToolkit), true) as MixedRealityToolkit;

        MixedRealityToolkit.TryGetSystem<XRTK.Interfaces.InputSystem.IMixedRealityInputSystem>(out InputSystem);
        //EventListener = new ReadOnlyObservableCollection<GameObject>((ObservableCollection<GameObject>)InputSystem?.EventListeners);
        InputSystem.OnInputEvent += correlator.dispatchEvent;
    }

    private void Start()
    {
    }

    private void Update()
    {
        if(cache?.Count != EventListener?.Count)
        {
            string breakpoint = "";
        }
        //print(cache?.ToString());
    }

    private void OnDisable()
    {
        print("disabled");
    }

    private void OnDestroy()
    {
        print("gettin killed!");
    }
}
