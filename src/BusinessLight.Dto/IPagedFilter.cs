﻿namespace BusinessLight.Dto
{
    public interface IPagedFilter
    {
        int PageNumber { get; set; }
        int PageSize { get; set; }
    }
}