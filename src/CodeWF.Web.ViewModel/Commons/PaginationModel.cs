﻿namespace CodeWF.Web.ViewModel.Commons;

public record PaginationModel(int Current, int[]? Pages, int Total, int PageSize, int PageCount,
    string DefaultParams = "");