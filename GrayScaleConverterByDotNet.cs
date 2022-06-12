public static class GrayScaleConverterByDotNet
{
    public static void ConvertToGrayScaleByDotNet(int sx, int sy, byte[] pixelData)
    {
        for (var x = 0; x < sx; x++)
        {
            for (var y = 0; y < sy; y++)
            {
                var ir = (x + y * sx) * 4;
                var ig = ir + 1;
                var ib = ir + 2;
                var r = pixelData[ir];
                var g = pixelData[ig];
                var b = pixelData[ib];
                var m = (byte)Math.Round(0.3 * r + 0.6 * g + 0.1 * b);
                pixelData[ir] = pixelData[ig] = pixelData[ib] = m;
            }
        }
    }

}