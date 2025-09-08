using EmbroideryThreadsApi.Models;

namespace EmbroideryThreadsApi.Data
{
    public class MockColorRepo : IColorsRepo
    {
        public IEnumerable<Color> GetAllColors()
        {
            var colorList = new List<Color>
            {
                new Color
                {
                    ColorId = 1,
                    ColorName = "White",
                    HexCode = "#FFFFFF"
                },
                new Color
                {
                    ColorId = 2,
                    ColorName = "Black",
                    HexCode = "#000000"
                },
                new Color
                {
                    ColorId = 3,
                    ColorName = "Red",
                    HexCode = "#FF0000"
                }
            };

            return colorList.ToList();
        }

        public Color GetColorById(int id)
        {
            return new Color
            {
                ColorId = 1,
                ColorName = "White",
                HexCode = "#FFFFFF"
            };
        }
    }
}
