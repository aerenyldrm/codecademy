def over_nine_thousand(case_list):
    sum = 0
    for element in case_list:
        sum += element
        if sum > 9000: return sum
    return sum

print(over_nine_thousand([8000, 900, 120, 5000]))