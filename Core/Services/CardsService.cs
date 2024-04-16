using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces;
using Core.Specifications;
using FluentValidation;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    internal class CardsService : ICardsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Card> cardsRepo;
        private readonly IValidator<CreateCardModel> validator;

        public CardsService(IMapper mapper, 
                            IRepository<Card> cardsR,
                            IValidator<CreateCardModel> validator)
        {
            this.mapper = mapper;
            this.validator = validator;
        }

        public async Task Create(CreateCardModel model)
        {
            validator.ValidateAndThrow(model);
            var card = mapper.Map<Card>(model);
            cardsRepo.Insert(card);
            cardsRepo.Save();
        }

        public async IEnumerable<CardDto> GetAllByUser(string userId)
        {
            return mapper.Map<List<CardDto>>(await cardsRepo.GetListBySpec(new CardSpecs.All()));
        }

        public Task Edit(EditCardModel model)
        {
            
        }

        public void Remove(int cardId)
        {
            if (cardId < 0) throw new HttpException(Errors.IdCanNotBeNegative, HttpStatusCode.BadRequest);

            var card = cardsRepo.GetById(cardId);
            if (card == null) throw new HttpException(Errors.ProductNotFound, HttpStatusCode.NotFound);

            cardsRepo.Delete(card);
            cardsRepo.Save();
        }
    }
}
