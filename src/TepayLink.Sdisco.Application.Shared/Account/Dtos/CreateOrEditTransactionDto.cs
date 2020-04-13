﻿using TepayLink.Sdisco.Account;
using TepayLink.Sdisco.Account;

using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace TepayLink.Sdisco.Account.Dtos
{
    public class CreateOrEditTransactionDto : EntityDto<long?>
    {

		public long UserId { get; set; }
		
		
		public decimal Amount { get; set; }
		
		
		public byte Side { get; set; }
		
		
		public TransactionType TransType { get; set; }
		
		
		public WalletTypeEnum WalletType { get; set; }
		
		
		public long? BookingDetailId { get; set; }
		
		
		public long? RefId { get; set; }
		
		
		public string Descrition { get; set; }
		
		

    }
}