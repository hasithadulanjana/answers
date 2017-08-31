namespace ComputePI
{
    interface IView
    {
        void Start();
        void Stop();
        string GetString(string prompt);
        void Show<T>(T message);
    }
}
