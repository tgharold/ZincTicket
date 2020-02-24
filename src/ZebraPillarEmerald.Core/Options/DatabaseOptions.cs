using System;
using ZebraPillarEmerald.Core.Attributes;
using ZebraPillarEmerald.Core.Interfaces;

namespace ZebraPillarEmerald.Core.Options
{
    [ConfigurationSectionName("Database")]
    public class DatabaseOptions : ICanValidate
    {
        public DatabaseSchemaNames SchemaNames { get; set; } = new DatabaseSchemaNames(); 
        public string DatabaseType { get; set; }
        
        public class DatabaseSchemaNames
        {
            public string ZebraPillarEmerald { get; set; } = "zpe";
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}