﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class T_MEMBERSEntity
    {
        public int OID { get; set; }
        public string Cname { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public int OrgID { get; set; }
        public int DeletionStateCode { get; set; }
        public int Enabled { get; set; }
        public int SortCode { get; set; }
        public string Description { get; set; }
        public DateTime CreateOn { get; set; }
        public int CreateUserId { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedUserId { get; set; }
        public string ModifiedBy { get; set; }

    }
}
