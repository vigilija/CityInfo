﻿namespace CityInfo.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }  = string.Empty;
        public string? Description { get; set; }

        public int NumberOfPointsOfIntrest
        {
            get
            {
                return PointOfIntrest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointOfIntrest { get; set; } = new List<PointOfInterestDto>();
    }
}
