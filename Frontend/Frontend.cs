using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;

public class Frontend : IFrontendLayer
{
    private readonly ILogicLayer logicLayer;

    public Frontend(ILogicLayer logicLayer)
    {
        this.logicLayer = logicLayer;
    }

    public void ShowTasks()
    {
        throw new NotImplementedException();
    }
}