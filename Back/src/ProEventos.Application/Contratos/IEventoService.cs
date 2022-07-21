using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEvento(int eventoId, Evento model);
        Task<bool> DeleteEvento(int eventoId);

        Task<Evento[]> getAllEventosAsync(bool includePalestrantes = false);
        Task<Evento[]> getAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento> getEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}