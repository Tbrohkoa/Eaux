using Verse;

namespace Eaux
{
    [StaticConstructorOnStartup]
    public static class Eaux
    {
        static Eaux()
        {
            Log.Message("EAUX - Hello World!");
        }
    }
}