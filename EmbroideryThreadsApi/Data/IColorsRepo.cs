using System.Collections.Generic;
using EmbroideryThreadsApi.Models;

namespace EmbroideryThreadsApi.Data
{
    public interface IColorsRepo
    {
        IEnumerable<Color> GetAllColors();

        Color GetColorById(int id);
    }
}
