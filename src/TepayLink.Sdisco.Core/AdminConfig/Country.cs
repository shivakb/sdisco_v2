﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace TepayLink.Sdisco.AdminConfig
{
	[Table("Countries")]
    public class Country : AuditedEntity , IMayHaveTenant
    {
			public int? TenantId { get; set; }
			

		public virtual string Name { get; set; }
		
		public virtual string DisplayName { get; set; }
		
		public virtual string Icon { get; set; }
		
		public virtual bool IsDisabled { get; set; }
		

    }
}