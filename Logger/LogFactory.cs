﻿namespace Logger;

public class LogFactory
{
    public string? FileName { get; set; }

    public BaseLogger? CreateLogger(string className) => 
        FileName is null ? null : new FileLogger(className, FileName);
        

    public void ConfigureFileLogger(string fileName) => FileName=fileName;
}
