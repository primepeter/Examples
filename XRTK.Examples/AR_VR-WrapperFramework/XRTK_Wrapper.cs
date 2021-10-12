using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;
using XRTK.Interfaces.InputSystem;
using XRTK.Services;



[ExecuteInEditMode]
[DisallowMultipleComponent]
public class XRTK_Wrapper : MonoBehaviour
{
    private static MixedRealityToolkit XRTK_Instance;
    //private IReadOnlyDictionary<System.Type, XRTK.Interfaces.IMixedRealitySystem> InputSystem = MixedRealityToolkit.ActiveSystems?.Where(system => (system. != null && system is InputSystem).First();
    private IMixedRealityInputSystem InputSystem;
    ReadOnlyObservableCollection<GameObject> EventListener = new ReadOnlyObservableCollection<GameObject>()

    private void Start()
    {
        XRTK_Instance = gameObject.GetComponentInChildren(typeof(MixedRealityToolkit), true) as MixedRealityToolkit;
        MixedRealityToolkit.TryGetSystem<XRTK.Interfaces.InputSystem.IMixedRealityInputSystem>(out InputSystem);
       EventListener = InputSystem.EventListeners
    }

    private void Update()
    {
        
    }


}
