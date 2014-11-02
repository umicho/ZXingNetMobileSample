using System;
using System.Threading.Tasks;

namespace ZXingNetMobileSample
{
    public interface IScanner
    {
        Task<string> ScanAsync();
    }
}

