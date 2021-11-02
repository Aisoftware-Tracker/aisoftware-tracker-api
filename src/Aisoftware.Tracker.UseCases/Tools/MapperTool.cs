using AutoMapper;

namespace Aisoftware.Tracker.UseCases.Tools
{
    public class MapperTool<T, E>
    {
        public IMapper Mapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T, E>();
                cfg.CreateMap<E, T>();
            })
            .CreateMapper();
        }
    }
}
