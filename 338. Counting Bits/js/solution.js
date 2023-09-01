/**
 * @param {number} n
 * @return {number[]}
 */
var countBits = function (n) {
    let result = [0];

    for (let i = 1; i <= n; i++) {
        let str = i.toString(2).replace(/0/g, "");
        result.push(str.length);
    }

    return result;
};