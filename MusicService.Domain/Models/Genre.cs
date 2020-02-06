﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MusicService.Domain.Models
{
    public class Genre : EntityBase
    {
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<ArtistGenre> ArtistGenres { get; set; }
    }
}
