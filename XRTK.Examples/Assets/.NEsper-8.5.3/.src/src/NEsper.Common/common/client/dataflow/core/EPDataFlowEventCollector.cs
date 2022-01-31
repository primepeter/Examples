///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2019 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

namespace com.espertech.esper.common.client.dataflow.core
{
    public interface EPDataFlowEventCollector
    {
        /// <summary>
        /// Collect: use the context to transform insert and remove stream events to data flow events.
        /// </summary>
        /// <param name="context">contains event beans, emitter and related information</param>
        void Collect(EPDataFlowEventCollectorContext context);
    }
}