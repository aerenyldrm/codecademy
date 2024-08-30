def max_num(numbers):
    for number in numbers:
        if numbers[0] < number: numbers[0] = number
    return numbers[0]

print(max_num([50, -10, 0, 75, 20]))