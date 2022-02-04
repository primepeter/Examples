///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2017 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace com.espertech.esper.client.deploy
{
    /// <summary>
    /// Result object of an undeployment operation.
    /// </summary>
    public class UndeploymentResult
    {
        /// <summary>Ctor. </summary>
        /// <param name="deploymentId">id generated by deployment operation</param>
        /// <param name="statementInfo">statement-level deployment information</param>
        public UndeploymentResult(String deploymentId, IList<DeploymentInformationItem> statementInfo)
        {
            DeploymentId = deploymentId;
            StatementInfo = statementInfo;
        }

        /// <summary>Returns the deployment id. </summary>
        /// <value>id</value>
        public string DeploymentId { get; private set; }

        /// <summary>Statement-level undeploy information. </summary>
        /// <value>statement INFO</value>
        public IList<DeploymentInformationItem> StatementInfo { get; private set; }
    }
}
