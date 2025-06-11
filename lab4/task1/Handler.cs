using System;

public abstract class Handler
{
    protected Handler? NextHandler { get; set; }

    public void SetNextHandler(Handler handler)
    {
        NextHandler = handler;
    }

    public abstract bool HandleRequest(string request);
} 