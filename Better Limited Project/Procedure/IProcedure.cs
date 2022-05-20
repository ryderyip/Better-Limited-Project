namespace Better_Limited_Project.Procedure
{
    public interface IProcedure<TEventArgs>
    {
        delegate void FinishedEventHandler<T>(object sender, T eventArgs);
        event FinishedEventHandler<TEventArgs> Finished;

        void Start();
    }
}