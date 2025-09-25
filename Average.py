def Average(nums):
    total = 0
    for num in nums:
        total += num
    return total/len(nums)
res = Average([1,2,3,4,5])
print(res)