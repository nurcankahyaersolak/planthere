﻿namespace PlantHere.Application.Interfaces.Queries
{
    public interface IQueryCacheable
    {
        TimeSpan Expiration { get; }
    }
}
