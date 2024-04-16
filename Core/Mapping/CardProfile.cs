using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Interfaces;
using System.Net;
using System.Net.Sockets;

namespace Core.Mapping
{
    public class CardProfile : Profile
    {
        public CardProfile(string host)
        {
            CreateMap<Card, CardDto>().ReverseMap();
            CreateMap<CardDto, Card>().ReverseMap();

            CreateMap<CreateCardModel, Card>().ReverseMap();

            CreateMap<EditCardModel, Card>().ReverseMap();
            CreateMap<EditCardModel, CardDto>().ReverseMap();
            CreateMap<Card, CardDto>().ReverseMap();
        }
    }
}
