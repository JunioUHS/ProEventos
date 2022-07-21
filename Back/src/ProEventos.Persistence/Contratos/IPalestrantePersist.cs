using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> getAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        Task<Palestrante[]> getAllPalestrantesAsync(bool includeEventos = false);
        Task<Palestrante> getPalestranteByIdAsync(int palestranteId, bool includeEventos = false);
    }
}