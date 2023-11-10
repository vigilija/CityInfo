using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "NY", Description = "With a park", PointOfIntrest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Liberty",
                        Description = "statue"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Manhaten",
                        Description = "Huge park"
                    }
                } },
                new CityDto() { Id = 2, Name = "Antwerp", Description = "With the cathedral", PointOfIntrest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 3,
                        Name = "Catedral",
                        Description = "Old church"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name = "Port",
                        Description = "Bigest port in EU"
                    }
                } },
                new CityDto() { Id = 3, Name = "Paris", Description = "With big tower", PointOfIntrest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 5,
                        Name = "Eiffel",
                        Description = "Tower"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 6,
                        Name = "Louvre",
                        Description = "Museum"
                    }
                } }
            };
        }
    }
}
