using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDBHelperServices.Models
{
    public partial class SysExportSchema02
    {
        public decimal? ProcessOrder { get; set; }
        public decimal? Duplicate { get; set; }
        public decimal? DumpFileid { get; set; }
        public decimal? DumpPosition { get; set; }
        public decimal? DumpLength { get; set; }
        public decimal? DumpOrigLength { get; set; }
        public decimal? DumpAllocation { get; set; }
        public decimal? CompletedRows { get; set; }
        public decimal? ErrorCount { get; set; }
        public decimal? ElapsedTime { get; set; }
        public string ObjectTypePath { get; set; }
        public decimal? ObjectPathSeqno { get; set; }
        public string ObjectType { get; set; }
        public string InProgress { get; set; }
        public string ObjectName { get; set; }
        public string ObjectLongName { get; set; }
        public string ObjectSchema { get; set; }
        public string OriginalObjectSchema { get; set; }
        public string OriginalObjectName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? DataobjNum { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Property { get; set; }
        public decimal? Trigflag { get; set; }
        public decimal? CreationLevel { get; set; }
        public DateTime? CompletionTime { get; set; }
        public string ObjectTablespace { get; set; }
        public decimal? SizeEstimate { get; set; }
        public decimal? ObjectRow { get; set; }
        public string ProcessingState { get; set; }
        public string ProcessingStatus { get; set; }
        public decimal? BaseProcessOrder { get; set; }
        public string BaseObjectType { get; set; }
        public string BaseObjectName { get; set; }
        public string BaseObjectSchema { get; set; }
        public decimal? AncestorProcessOrder { get; set; }
        public decimal? DomainProcessOrder { get; set; }
        public decimal? Parallelization { get; set; }
        public decimal? UnloadMethod { get; set; }
        public decimal? LoadMethod { get; set; }
        public decimal? Granules { get; set; }
        public decimal? Scn { get; set; }
        public string Grantor { get; set; }
        public string XmlClob { get; set; }
        public decimal? ParentProcessOrder { get; set; }
        public string Name { get; set; }
        public string ValueT { get; set; }
        public decimal? ValueN { get; set; }
        public decimal? IsDefault { get; set; }
        public decimal? FileType { get; set; }
        public string UserDirectory { get; set; }
        public string UserFileName { get; set; }
        public string FileName { get; set; }
        public decimal? ExtendSize { get; set; }
        public decimal? FileMaxSize { get; set; }
        public string ProcessName { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string WorkItem { get; set; }
        public decimal? ObjectNumber { get; set; }
        public decimal? CompletedBytes { get; set; }
        public decimal? TotalBytes { get; set; }
        public decimal? MetadataIo { get; set; }
        public decimal? DataIo { get; set; }
        public decimal? CumulativeTime { get; set; }
        public decimal? PacketNumber { get; set; }
        public decimal? InstanceId { get; set; }
        public string OldValue { get; set; }
        public decimal? Seed { get; set; }
        public decimal? LastFile { get; set; }
        public string UserName { get; set; }
        public string Operation { get; set; }
        public string JobMode { get; set; }
        public decimal? QueueTabnum { get; set; }
        public string ControlQueue { get; set; }
        public string StatusQueue { get; set; }
        public string RemoteLink { get; set; }
        public decimal? Version { get; set; }
        public string JobVersion { get; set; }
        public string DbVersion { get; set; }
        public string Timezone { get; set; }
        public string State { get; set; }
        public decimal? Phase { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? BlockSize { get; set; }
        public decimal? MetadataBufferSize { get; set; }
        public decimal? DataBufferSize { get; set; }
        public decimal? Degree { get; set; }
        public string Platform { get; set; }
        public decimal? AbortStep { get; set; }
        public string Instance { get; set; }
        public decimal? ClusterOk { get; set; }
        public string ServiceName { get; set; }
        public string ObjectIntOid { get; set; }
    }
}
