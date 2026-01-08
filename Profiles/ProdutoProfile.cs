using AutoMapper;
using Product.Api.DTOs;
using Product.Api.Models;

namespace Product.Api.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
            CreateMap<UpdateProdutoDto, Produto>();
        }
    }
}
