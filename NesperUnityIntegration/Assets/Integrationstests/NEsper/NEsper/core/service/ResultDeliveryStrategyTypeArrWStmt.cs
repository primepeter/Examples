///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2017 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Reflection;

using com.espertech.esper.client;
using com.espertech.esper.collection;
using com.espertech.esper.compat.logging;
using com.espertech.esper.epl.core;

namespace com.espertech.esper.core.service
{
    public class ResultDeliveryStrategyTypeArrWStmt : ResultDeliveryStrategyTypeArr
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResultDeliveryStrategyTypeArrWStmt(EPStatement statement, object subscriber, MethodInfo method, Type componentType, EngineImportService engineImportService)
            : base(statement, subscriber, method, componentType, engineImportService)
        {
        }

        public override void Execute(UniformPair<EventBean[]> result)
        {
            object newData;
            object oldData;

            if (result == null)
            {
                newData = null;
                oldData = null;
            }
            else
            {
                newData = Convert(result.First);
                oldData = Convert(result.Second);
            }

            object[] parameters = new object[] { _statement, newData, oldData };
            try
            {
                _fastMethod.Invoke(_subscriber, parameters);
            }
            catch (TargetInvocationException e)
            {
                ResultDeliveryStrategyImpl.Handle(_statement.Name, Log, e, parameters, _subscriber, _fastMethod);
            }
        }
    }
} // end of namespace
