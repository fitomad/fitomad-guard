namespace Fitomad.Guard;

public sealed partial class Guard
{
    internal static Action ArgumentAction = () => {
        throw new ArgumentException();
    };

    internal static Action RangeAction = () => {
        throw new IndexOutOfRangeException();
    };

    private static void Execute(Action code)
    {
        try 
        {
            code();
            throw new ArgumentException();
        }
        catch
        {
            throw;
        }
    }
}
