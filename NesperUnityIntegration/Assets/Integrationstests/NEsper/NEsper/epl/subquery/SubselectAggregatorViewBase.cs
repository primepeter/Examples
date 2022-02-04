///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2017 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

using com.espertech.esper.client;
using com.espertech.esper.collection;
using com.espertech.esper.epl.agg.service;
using com.espertech.esper.epl.expression.core;
using com.espertech.esper.epl.expression;
using com.espertech.esper.view;

namespace com.espertech.esper.epl.subquery
{
    /// <summary>
    /// View handling the insert and remove stream generated by a subselect for application to aggregation state.
    /// </summary>
    public abstract class SubselectAggregatorViewBase : ViewSupport
    {
        protected readonly AggregationService AggregationService;
        protected readonly ExprEvaluator OptionalFilterExpr;
        protected readonly ExprEvaluatorContext ExprEvaluatorContext;
        protected readonly ExprEvaluator[] GroupKeys;
        protected readonly EventBean[] EventsPerStream = new EventBean[1];

        public SubselectAggregatorViewBase(
            AggregationService aggregationService,
            ExprEvaluator optionalFilterExpr,
            ExprEvaluatorContext exprEvaluatorContext,
            ExprEvaluator[] groupKeys)
        {
            AggregationService = aggregationService;
            OptionalFilterExpr = optionalFilterExpr;
            ExprEvaluatorContext = exprEvaluatorContext;
            GroupKeys = groupKeys;
        }

        public override EventType EventType
        {
            get { return Parent.EventType; }
        }

        public override IEnumerator<EventBean> GetEnumerator()
        {
            return Parent.GetEnumerator();
        }

        protected bool Filter(bool isNewData)
        {
            var result =
                (bool?)
                    OptionalFilterExpr.Evaluate(new EvaluateParams(EventsPerStream, isNewData, ExprEvaluatorContext));
            return result ?? false;
        }

        protected Object GenerateGroupKey(bool isNewData)
        {
            var evaluateParams = new EvaluateParams(EventsPerStream, isNewData, ExprEvaluatorContext);

            if (GroupKeys.Length == 1)
            {
                return GroupKeys[0].Evaluate(evaluateParams);
            }
            var keys = new Object[GroupKeys.Length];
            for (int i = 0; i < GroupKeys.Length; i++)
            {
                keys[i] = GroupKeys[i].Evaluate(evaluateParams);
            }
            return new MultiKeyUntyped(keys);
        }
    }
}