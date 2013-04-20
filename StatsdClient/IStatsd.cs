﻿using System;
namespace StatsdClient
{
  public interface IStatsd
  {
    void LogCount(string name, int count = 1);
    void LogGauge(string name, int value);
    void LogTiming(string name, int milliseconds);
  }
}
