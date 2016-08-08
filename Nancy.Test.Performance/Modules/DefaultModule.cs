namespace Nancy.Test.Performance.Modules
{
    public class DefaultModule 
        : NancyModule
    {
        public DefaultModule()
        {
            Get["/"] = Home;
        }

        private dynamic Home(dynamic parameters)
        {
            return View["Home"];
        }
    }
}