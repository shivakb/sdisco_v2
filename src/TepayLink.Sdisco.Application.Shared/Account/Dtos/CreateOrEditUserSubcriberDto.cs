﻿
using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace TepayLink.Sdisco.Account.Dtos
{
    public class CreateOrEditUserSubcriberDto : EntityDto<long?>
    {

		public string Email { get; set; }
		
		

    }
}