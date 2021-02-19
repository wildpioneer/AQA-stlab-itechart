using System.Collections.Generic;

namespace Lesson3.Interfaces
{
    public interface IReportGenerator<T>
    {
        void GenerateReport(List<T> data);
    }
}