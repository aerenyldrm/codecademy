def divisible_by_ten(nums):
    counter = 0
    for num in nums:
        if num % 10 == 0: counter += 1
    return counter

print(divisible_by_ten([20, 25, 30, 35, 40]))