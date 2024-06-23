﻿using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskExecutionHistory : ITaskExecutionHistory
    {
        public string? Description { get; set; }
        public string? ExecutionFinished { get; set; }
        public string? ExecutionPlanned { get; set; }
        public string? ExecutionProtocol { get; set; }
        public string? ExecutionStarted { get; set; }
        public int? ExecutionStatus { get; set; }
        public string? Guid { get; set; }
        public string? ProjectName { get; set; }
        public PssTask? PssTask { get; set; }
        public long? PssTaskId { get; set; }
        public string? ScriptConfiguration { get; set; }
        public string? ScriptName { get; set; }
        public string? ServerName { get; set; }
        public int? Status { get; set; }
        public long TaskExecutionHistoryId { get; set; }
        public string? TaskName { get; set; }
        public string? TriggerMode { get; set; }
    }
}
