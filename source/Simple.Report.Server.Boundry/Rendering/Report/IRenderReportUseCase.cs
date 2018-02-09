﻿using TddBuddy.CleanArchitecture.Domain;
using TddBuddy.CleanArchitecture.Domain.Output;

namespace Mustache.Reports.Boundry.Rendering.Report
{
    public interface IRenderReportUseCase : IUseCase<RenderReportInput, IFileOutput>
    {
    }
}
