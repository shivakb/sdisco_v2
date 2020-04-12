﻿
using System;
using Abp.Application.Services.Dto;

namespace TepayLink.Sdisco.Account.Dtos
{
    public class UserReviewDto : EntityDto
    {
		public long UserId { get; set; }

		public double ReviewCount { get; set; }

		public double Itineraty { get; set; }

		public double Service { get; set; }

		public double Transport { get; set; }

		public double GuideTour { get; set; }

		public double Food { get; set; }

		public double Rating { get; set; }



    }
}