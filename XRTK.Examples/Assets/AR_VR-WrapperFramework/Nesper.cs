using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assets.AR_VR_WrapperFramework
{
    //public class Nesper
    //{
    //    public EPServiceProvider epService;
    //    // Configure the engine, this is optional
    //    public Configuration config;
    //    public EPAdministrator admin;

    //    public Nesper()
    //    {
    //        this.epService = EPServiceProviderManager.GetDefaultProvider();
    //        this.config = new Configuration();
    //    }

    //    public Nesper(EPServiceProvider epService, Configuration config)
    //    {
    //        this.epService = epService ?? throw new ArgumentNullException(nameof(epService));
    //        this.config = config ?? throw new ArgumentNullException(nameof(config));
    //    }

    //    public void init()
    //    {
    //        config.AddEventType(typeof(PersonEvent));
    //        // config.Configure("configuration.xml");  // load a configuration from file
    //        // config.set....(...);    // make additional configuration settings
    //        // Obtain an engine instance
    //        EPServiceProvider epService = EPServiceProviderManager.GetDefaultProvider(config);
    //        // Optionally, use initialize if the same engine instance has been used before to start clean
    //        epService.Initialize();
    //        // Optionally, make runtime configuration changes
    //        admin = epService.EPAdministrator; // get admin and runtime only after initialization
    //        // epService.getEPAdministrator().getConfiguration().add...(...);
    //        EPStatement statement = admin.CreateEPL("@name('my-statement') select name, age from PersonEvent");
    //        //CompilerArguments args = new CompilerArguments(config);
    //        EPStatementObjectModel epCompiled;
    //        try
    //        {
    //            epCompiled = admin.CompileEPL("@name('my-statement') select name, age from PersonEvent");
    //        }
    //        catch (EPStatementException ex)
    //        {
    //            // handle exception here
    //            throw new EPRuntimeException(ex);
    //        }
    //    }
           

    //    private class PersonEvent
    //    {

    //        private String name { get; set; }
    //        private int age { get; set; }
    //        public PersonEvent(String name, int age)
    //        {
    //            this.name = name;
    //            this.age = age;
    //        }
    //    }
    //}
}

