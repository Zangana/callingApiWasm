using System;
using System.Collections.Generic;

namespace accounting.Models
{
    public partial class CfgUserType
    {
        public CfgUserType()
        {
            TblUserProfiles = new HashSet<TblUserProfile>();
        }

        public long TypId { get; set; }
        public string? TypName { get; set; }
        public long? TypCreatedBy { get; set; }
        public DateTime? TypCreatedDate { get; set; }
        public long? TypUpdatedBy { get; set; }
        public DateTime? TypUpdatedDate { get; set; }
        public long? TypDeletedBy { get; set; }
        public DateTime? TypDeletedDate { get; set; }
        public byte? TypDeleted { get; set; }

        public virtual ICollection<TblUserProfile> TblUserProfiles { get; set; }
    }
}
