using System;
using System.Threading.Tasks;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency (typeof (ZXingNetMobileSample.Android.Scanner_Android))]

namespace ZXingNetMobileSample.Android
{
    public class Scanner_Android : IScanner
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner(Xamarin.Forms.Forms.Context);
            var result = await scanner.Scan();

            if (result != null)
            {
                return result.Text;
            }
            return string.Empty;
        }
    }
}

