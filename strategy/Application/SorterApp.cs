using Interfaces;

namespace Application{
    public class SorterApp{
        private readonly ISorter app;
        public SorterApp(ISorter application)
        {
            app = application;
        }
        public int RunApp() {
            app.Run();
            app.Instructions();
            app.Done();
            return 1;
        }
    }
}