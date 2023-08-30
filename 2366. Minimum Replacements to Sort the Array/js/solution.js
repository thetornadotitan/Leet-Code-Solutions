/**
 * @param {number[]} nums
 * @return {number}
 */
var minimumReplacement = function (nums) {
    let steps = 0;

    for (let i = nums.length - 2; i >= 0; i--) {
        if (nums[i] <= nums[i + 1]) continue;

        const stepsNeeded = Math.floor((nums[i] + nums[i + 1] - 1) / nums[i + 1]);
        steps += stepsNeeded - 1;
        nums[i] = Math.floor(nums[i] / stepsNeeded);
    }

    return steps;
};