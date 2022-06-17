export function convertToGrayScaleByJS(sx, sy, pixelData) {
    for (var x = 0; x < sx; x++) {
        for (var y = 0; y < sy; y++) {
            const ir = (x + y * sx) * 4;
            const ig = ir + 1;
            const ib = ir + 2;
            const r = pixelData[ir];
            const g = pixelData[ig];
            const b = pixelData[ib];
            const m = Math.round(0.3 * r + 0.6 * g + 0.1 * b);
            pixelData[ir] = pixelData[ig] = pixelData[ib] = m;
        }
    }
    return pixelData;
}
