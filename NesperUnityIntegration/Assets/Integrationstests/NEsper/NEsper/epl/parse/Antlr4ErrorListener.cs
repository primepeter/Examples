///////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2006-2017 Esper Team. All rights reserved.                           /
// http://esper.codehaus.org                                                          /
// ---------------------------------------------------------------------------------- /
// The software in this package is published under the terms of the GPL license       /
// a copy of which has been included with this distribution in the license.txt file.  /
///////////////////////////////////////////////////////////////////////////////////////

using System.IO;
using System.Reflection;

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Sharpen;

using com.espertech.esper.compat.logging;

namespace com.espertech.esper.epl.parse
{
    public class Antlr4ErrorListener<T> : IAntlrErrorListener<T>
    {
        public static readonly Antlr4ErrorListener<T> INSTANCE = new Antlr4ErrorListener<T>();

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private Antlr4ErrorListener()
        {
        }

        public void SyntaxError(
            IRecognizer recognizer,
            T offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e)
        {
            throw e;
        }

        public void SyntaxError(
            TextWriter output,
            IRecognizer recognizer,
            T offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e)
        {
            throw e;
        }

        public void ReportAmbiguity(
            Parser recognizer,
            DFA dfa,
            int startIndex,
            int stopIndex,
            bool exact,
            BitSet ambigAlts,
            ATNConfigSet configs)
        {
            Log.Debug("reportAmbiguity");
        }

        public void ReportAttemptingFullContext(
            Parser recognizer,
            DFA dfa,
            int startIndex,
            int stopIndex,
            BitSet conflictingAlts,
            ATNConfigSet configs)
        {
            Log.Debug("reportAttemptingFullContext");
        }

        public void ReportContextSensitivity(
            Parser recognizer,
            DFA dfa,
            int startIndex,
            int stopIndex,
            int prediction,
            ATNConfigSet configs)
        {
            Log.Debug("reportContextSensitivity");
        }
    }
} // end of namespace