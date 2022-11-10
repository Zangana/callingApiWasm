using System;
using System.Collections.Generic;


/**
 * This is a model which needs to be same as like the json. 
 * It is case senstive. 
 * 
 */
namespace accounting.Models
{
    public partial class TblUserProfile
    {
        public long usrId { get; set; } 

        public string? usrName { get; set; }
        public string? usrPassword { get; set; }
        public long? usrCreatedBy { get; set; }
        public DateTime? usrCreatedDate { get; set; }
        public long? usrUpdatedBy { get; set; }
        public DateTime? usrUpdatedDate { get; set; }
        public long? usrDeletedBy { get; set; }
        public DateTime? usrDeletedDate { get; set; }
        public byte? usrDeleted { get; set; }
        public long? usrTypes { get; set; }

        public virtual CfgUserType? usrTypesNavigation { get; set; }
    }
}
