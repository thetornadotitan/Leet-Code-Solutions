/**
 * @param {string} customers
 * @return {number}
 */
var bestClosingTime = function (customers) {
    let pen = 0;
    let minPen = 0;
    let idx = 0;

    for (let i = 0; i < customers.length; i++) {
        const s = customers[i];

        if (s === 'Y') pen--;
        if (s === 'N') pen++;

        if (pen < minPen) {
            idx = i + 1;
            minPen = pen;
        }
    }

    return idx;
};