using Ideastudio.Domain;
using Ideastudio.Models.LokacijskaDozvola.CreateLokacijskaDozvola;
using Ideastudio.Models.LokacijskaDozvola.EditLokacijskaDozvola;

namespace Ideastudio.Profile
{
    public class LokacijskeDozvoleProfile : AutoMapper.Profile
    {
        public LokacijskeDozvoleProfile()
        {
            CreateMap<CreateLokacijskaDozvolaRequest, LokacijskaDozvola>()
                .ReverseMap();

            CreateMap<CreateLokacijskaDozvolaResponse, LokacijskaDozvola>()
                .ReverseMap();

            CreateMap<EditLokacijskaDozvolaRequest, LokacijskaDozvola>()
                .ReverseMap();

            CreateMap<EditLokacijskaDozvolaResponse, LokacijskaDozvola>()
                .ReverseMap();
        }
    }
}
