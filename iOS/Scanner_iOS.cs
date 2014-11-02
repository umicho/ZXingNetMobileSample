using System;
using System.Threading.Tasks;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency (typeof (ZXingNetMobileSample.iOS.Scanner_iOS))]

namespace ZXingNetMobileSample.iOS
{
    public class Scanner_iOS : IScanner
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner();
            var result = await scanner.Scan();

            if (result != null)
            {
                return result.Text;
            }
            return string.Empty;
        }
    }
}

