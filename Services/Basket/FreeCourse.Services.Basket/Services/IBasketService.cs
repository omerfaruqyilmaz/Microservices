﻿using FreeCourse.Services.Basket.Dtos;
using System.Threading.Tasks;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Basket.Services
{
	public interface IBasketService
	{
		Task<Response<BasketDto>> GetBasket(string userId);

		Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);

		Task<Response<bool>> Delete(string userId);
	}

}
