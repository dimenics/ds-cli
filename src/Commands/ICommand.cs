﻿using System.Threading.Tasks;

namespace Dime.Scheduler.DotNetTool.Commands
{
    internal interface ICommand<in TOptions>
    {
        Task ProcessAsync(TOptions options);
    }
}