using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.espertech.esper.client;
using com.espertech.esper.compat;
using System.Diagnostics;

namespace Assets.AR_VR_WrapperFramework
{
    //public class Nesper
    //{
    //    EPCompiler compiler;
    //    // Configure the engine, this is optional
    //    public Configuration config;
    //    EPRuntime runtime;

    //    public Nesper()
    //    {
    //        this.compiler = EPCompilerProvider.GetCompiler();
    //        this.config = new Configuration();
    //    }

    //    public Nesper(EPCompiler compiler, Configuration config)
    //    {
    //        this.compiler = compiler ?? throw new ArgumentNullException(nameof(compiler));
    //        this.config = config ?? throw new ArgumentNullException(nameof(config));
    //    }

    //    public void Init()
    //    {
    //        config.Common.AddEventType(typeof(PersonEvent));
    //        // config.Configure("configuration.xml");  // load a configuration from file
    //        // config.set....(...);    // make additional configuration settings
    //        // create statement
    //        String statement = "@name('my-statement') select name, age from PersonEvent";
    //        // Obtain an engine instance
    //        // Optionally, use initialize if the same engine instance has been used before to start clean
    //        runtime ??= EPRuntimeProvider.GetDefaultRuntime(config);
    //        runtime.Initialize();
    //        CompilerArguments args = new CompilerArguments(config);
    //        EPCompiled epCompiled;
    //        try
    //        {
    //            epCompiled = compiler.Compile(statement, args);
    //        }
    //        catch (EPCompileException ex)
    //        {
    //            // handle exception here
    //            throw new EPRuntimeException(ex);
    //        }
    //    }

    //    public void Deploy(EPCompiled epCompiled)
    //    {
    //        EPDeployment deployment;
    //        try
    //        {
    //            deployment = runtime.DeploymentService.Deploy(epCompiled);
    //        }
    //        catch (EPDeployException ex)
    //        {
    //            throw new EPRuntimeException(ex); ;
    //        }
    //    }

    //    public delegate void Listener(string newdata, string olddata, EPStatement statement, EPRuntime runtime);
    //    public void AddListener(EPStatement statement, Delegate d)
    //    {
    //        statement.Events += (sender, args) =>
    //        {
    //            string name = (string)args.NewEvents[0].Get("name");
    //            int age = (int)args.NewEvents[0].Get("age");
    //            System.Console.WriteLine(String.Format("Name: %s, Age: %d", name, age));
    //        };
    //    }
    //}
    //class PersonEvent
    //{
    //    private String name { get; set; }
    //    private int age { get; set; }
    //    public PersonEvent(String name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //}
}

