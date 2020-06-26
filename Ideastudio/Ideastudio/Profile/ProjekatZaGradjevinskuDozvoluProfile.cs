using Ideastudio.Domain;
using Ideastudio.Models.ProjekatZaGradjevinskuDozvolu.CreateProjekatZaGradjevinskuDozvolu;
using Ideastudio.Models.ProjekatZaGradjevinskuDozvolu.EditProjekatZaGradjevinskuDozvolu;

namespace Ideastudio.Profile
{
    public class ProjekatZaGradjevinskuDozvoluProfile : AutoMapper.Profile
    {
        public ProjekatZaGradjevinskuDozvoluProfile()
        {
            CreateMap<CreateProjekatZaGradjevinskuDozvoluRequest, ProjekatZaGradjevinskuDozvolu>()
                .ForMember(d => d.Povrsine, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<CreateProjekatZaGradjevinskuDozvoluResponse, ProjekatZaGradjevinskuDozvolu>()
                .ReverseMap();

            CreateMap<EditProjekatZaGradjevinskuDozvoluRequest, ProjekatZaGradjevinskuDozvolu>()
                .ReverseMap();

            CreateMap<EditProjekatZaGradjevinskuDozvoluResponse, ProjekatZaGradjevinskuDozvolu>()
                .ReverseMap();
        }
    }
}
