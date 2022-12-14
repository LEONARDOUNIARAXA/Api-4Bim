using Aula01.Domain;
using Aula01.Model;
using AutoMapper;

namespace Aula01.Mapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<ProdutoViewModel, Produto>()
			   .ConstructUsing(q => new Produto(q.Id,q.Nome, q.Preco, q.Estoque));
		}
	}
}
