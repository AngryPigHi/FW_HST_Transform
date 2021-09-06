using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class SCsWorkflow
    {
        public long? Category { get; set; }
        public string ChildNodeId { get; set; }
        public string FatherNodeId { get; set; }
        public string FileName { get; set; }
        public string FunDescription { get; set; }
        public string HelpName { get; set; }
        public long? LevelNum { get; set; }
        public string MisDescription { get; set; }
        public long NodeId { get; set; }
        public string NodeName { get; set; }
        public string PreconditionNode { get; set; }
        public string State { get; set; }
        public string TrigerFunction { get; set; }
        public string TrigerPlugin { get; set; }
        public string Weight { get; set; }
    }
}
