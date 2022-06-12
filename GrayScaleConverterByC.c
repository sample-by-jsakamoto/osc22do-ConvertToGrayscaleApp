#include <math.h>

void convertToGrayScaleByC(int sx, int sy, unsigned char *pixelData)
{
    for (int x = 0; x < sx; x++)
    {
        for (int y = 0; y < sy; y++)
        {
            int ir = (x + y * sx) * 4;
            int ig = ir + 1;
            int ib = ir + 2;
            unsigned char r = pixelData[ir];
            unsigned char g = pixelData[ig];
            unsigned char b = pixelData[ib];
            unsigned char m = (unsigned char)round(0.3 * r + 0.6 * g + 0.1 * b);
            pixelData[ir] = pixelData[ig] = pixelData[ib] = m;
        }
    }
}