﻿
namespace ToDoList.Services.Handlers
{
    public class CommandResult 
    {
        public CommandResult(bool success)
        {
            IsSuccess = success;
        }

        public bool IsSuccess { get; }
    }
}
