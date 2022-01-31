using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using XRTK.EventDatum.Input;
using XRTK.Interfaces.InputSystem;

namespace Assets.AR_VR_WrapperFramework
{
    class EventCorrelator 
    {
        private IEnumerable<GameObject> Events; //Think of best DataStructure

        //Remarks - XRTK DOC:
        //In order to stop an input event from propagating through its execution as outlined, a component can call AbstractEventData.Use() to mark the event as used.
        //This will stop any other GameObjects from receiving the current input event, with the exception of global input handlers.
        //A component that calls the Use() method will stop other GameObjects from receiving it.However
        //, other components on the current GameObject will still receive the input event and fire any related interface functions.


        public void dispatchEvent(BaseInputEventData eventData)
        {
            //eventData go to collection
            eventData.Use(); //TODO globald listener get the event anyway (9
        }
    }
}
